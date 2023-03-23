//------------------------------------------------------------------------------
// <copyright file="Images.cs" company="Alton X Lam">
// Copyright © 2013 Alton Lam
//
// This software is provided 'as-is', without any express or implied
// warranty. In no event will the authors be held liable for any damages
// arising from the use of this software.
//
// Permission is granted to anyone to use this software for any purpose,
// including commercial applications, and to alter it and redistribute it
// freely, subject to the following restrictions:
//
// 1. The origin of this software must not be misrepresented; you must not
//    claim that you wrote the original software. If you use this software
//    in a product, an acknowledgment in the product documentation would be
//    appreciated but is not required.
//
// 2. Altered source versions must be plainly marked as such, and must not be
//    misrepresented as being the original software.
//
// 3. This notice may not be removed or altered from any source distribution.
//
// Alton X Lam
// https://www.facebook.com/AltonXL
// https://www.codeplex.com/site/users/view/AltonXL
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using ExcelDna.Integration;
using Microsoft.Office.Interop.Excel;

namespace ImageMso.Excel
{
    ///<summary>Encapsulates collections, methods and structures to extract ImageMso icons from the Microsoft Excel application.</summary>
    ///<remarks><para>The collection of 8,899 distinct ImageMso names in this class are a composite list formed by the union of values 
    ///collected from "2007 Office System Add-In: Icons Gallery", "Office 2010 Add-In: Icons Gallery", "Appendix A: Custom UI Control 
    ///ID Tables, [MS-CUSTOMUI]: imageMso Table" and "Microsoft Office Document: [MS-CUSTOMUI2] Supporting Documentation".</para>
    ///<para>The methods and structures in this class are based off the answer provided on Stack Overflow by Ismail Degani in response 
    ///to the question "How to save ImageMSO icon from Microsoft Office 2007?" which was in turn based off the MSDN blog post 
    ///"Preserving the alpha channel when converting images" by Andrew Whitechapel.</para>
    ///<seealso href="https://www.microsoft.com/en-us/download/details.aspx?id=11675">
    ///2007 Office System Add-In: Icons Gallery</seealso>
    ///<seealso href="https://www.microsoft.com/en-us/download/details.aspx?id=21103">
    ///Office 2010 Add-In: Icons Gallery</seealso>
    ///<seealso href="http://msdn.microsoft.com/en-us/library/dd953682.aspx">
    ///Appendix A: Custom UI Control ID Tables, [MS-CUSTOMUI]: imageMso Table</seealso>
    ///<seealso href="https://www.microsoft.com/en-us/download/details.aspx?id=727">
    ///Microsoft Office Document: [MS-CUSTOMUI2] Supporting Documentation</seealso>
    ///<seealso href="http://stackoverflow.com/questions/1073322/how-to-save-imagemso-icon-from-microsoft-office-2007">
    ///How to save ImageMSO icon from Microsoft Office 2007?</seealso>
    ///<seealso href="http://blogs.msdn.com/b/andreww/archive/2007/10/10/preserving-the-alpha-channel-when-converting-images.aspx">
    ///Preserving the alpha channel when converting images</seealso>
    ///</remarks>
    partial class Images
    {
        ///<summary>Initializes a new instance of the <see cref="Images" /> class.
        ///Intended only for use by the static <see cref="Images.Default" /> property.</summary>
        ///<remarks>The constructor builds the complete sorted collection of distinct ImageMso 
        ///names supported by the host Microsoft Office version by constructing from the partial 
        ///collections and excluding the excluded ImageMso names for the host version of 
        ///Microsoft Office. The exceedingly complex expressions, for applications settings such 
        ///as the entire collection of distinct ImageMso names, are beyond the abilities of 
        ///Visual Studio to compile as a whole but are workable in parts.</remarks>
        private Images()
        { // Remove ImageMso names not supported by the host version of Microsoft Office.
            var exclude =
                (ExcelDnaUtil.ExcelVersion >= 15d) ? Exclude2013 : // Microsoft Office 2013
                (ExcelDnaUtil.ExcelVersion >= 14d) ? Exclude2010 : // Microsoft Office 2010
                (ExcelDnaUtil.ExcelVersion >= 12d) ? Exclude2007 : // Microsoft Office 2007
                null; // Microsoft Office 2003 or XP or even earlier. ImageMso not supported.
            if (exclude != null)
            {
                foreach (string name in NamesTop) if (!exclude.Contains(name)) Names.Add(name);
                foreach (string name in NamesBottom) if (!exclude.Contains(name)) Names.Add(name);
            }
        }

        ///<summary>Draws a <see cref="System.Drawing.Bitmap" /> copy of the ImageMso 
        ///from Microsoft Excel at the specified width and height.</summary>
        ///<param name="name">ImageMso name.</param>
        ///<param name="width">Width in pixels.</param>
        ///<param name="height">Height in pixels.</param>
        ///<returns>This method returns a <see cref="System.Drawing.Bitmap" /> image of the
        ///specified ImageMso copied from Microsoft Excel with the specified width and height
        ///or null if the specified ImageMso is not supported by the host version of Microsoft
        ///Office.</returns>
        ///<remarks>This method wraps the static <see cref="Images.Draw(string, int, int)" />
        ///method for instantiated classes.</remarks>
        public Bitmap this[string name, int width, int height]
        {
            get { return Draw(name, width, height); }
        }

        ///<summary>Draws a <see cref="System.Drawing.Bitmap" /> copy of the ImageMso 
        ///from Microsoft Excel at the specified width and height.</summary>
        ///<param name="name">ImageMso name.</param>
        ///<param name="width">Width in pixels. Default is 32.</param>
        ///<param name="height">Height in pixels. Default is 32.</param>
        ///<returns>This method returns a <see cref="System.Drawing.Bitmap" /> image of the
        ///specified ImageMso copied from Microsoft Excel with the specified width and height
        ///or null if the specified ImageMso is not supported by the host version of Microsoft
        ///Office.</returns>
        ///<remarks>This method gets the <see cref="stdole.IPictureDisp" /> from the Microsoft 
        ///Excel application, checks if the image is 24bpp RGB or 32bpp ARGB and copies the 
        ///image pixel for pixel to a new Bitmap to preserve or discard the alpha channel.
        ///</remarks>
        public static Bitmap Draw(string name, int width = 32, int height = 32)
        {
            try
            { // Throws an ArgumentException if the ImageMso name is not supported.
                var ipd = ((Application)ExcelDnaUtil.Application).CommandBars.GetImageMso(name, width, height);

                // Gets the info about the HBITMAP inside the IPictureDisp.
                var dibsection = new DIBSECTION();
                GetObjectDIBSection((IntPtr)ipd.Handle, Marshal.SizeOf(dibsection), ref dibsection);
                var w = dibsection.dsBm.bmWidth;
                var h = dibsection.dsBm.bmHeight;

                // Create the destination Bitmap object.
                var image = new Bitmap(w, h, PixelFormat.Format32bppArgb);

                unsafe
                {
                    // Gets a pointer to the raw bits.
                    var pBits = (RGBQUAD*)(void*)dibsection.dsBm.bmBits;

                    // Scan the image to check if alpha channel is empty
                    // 24bpp RGB when false, 32bpp ARGB when true.
                    bool alpha = false;
                    for (int x = 0; x < dibsection.dsBmih.biWidth; x++)
                        for (int y = 0; y < dibsection.dsBmih.biHeight; y++)
                            alpha |= pBits[y * dibsection.dsBmih.biWidth + x].rgbReserved != 0;

                    // Copy each pixel byte for byte.
                    for (int x = 0; x < dibsection.dsBmih.biWidth; x++)
                        for (int y = 0; y < dibsection.dsBmih.biHeight; y++)
                        {
                            var offset = y * dibsection.dsBmih.biWidth + x;
                            if (pBits[offset].rgbReserved != 0)
                                image.SetPixel(x, y, Color.FromArgb(pBits[offset].rgbReserved, pBits[offset].rgbRed, pBits[offset].rgbGreen, pBits[offset].rgbBlue));
                            else if (!alpha)
                                image.SetPixel(x, y, Color.FromArgb(pBits[offset].rgbRed, pBits[offset].rgbGreen, pBits[offset].rgbBlue));
                        }
                }
                return image;
            }
            catch (ArgumentException)
            { // The ImageMso name is not supported.
                return null;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct RGBQUAD
        {
            public byte rgbBlue;
            public byte rgbGreen;
            public byte rgbRed;
            public byte rgbReserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct BITMAP
        {
            public Int32 bmType;
            public Int32 bmWidth;
            public Int32 bmHeight;
            public Int32 bmWidthBytes;
            public Int16 bmPlanes;
            public Int16 bmBitsPixel;
            public IntPtr bmBits;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct BITMAPINFOHEADER
        {
            public int biSize;
            public int biWidth;
            public int biHeight;
            public Int16 biPlanes;
            public Int16 biBitCount;
            public int biCompression;
            public int biSizeImage;
            public int biXPelsPerMeter;
            public int biYPelsPerMeter;
            public int biClrUsed;
            public int bitClrImportant;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct DIBSECTION
        {
            public BITMAP dsBm;
            public BITMAPINFOHEADER dsBmih;
            public int dsBitField1;
            public int dsBitField2;
            public int dsBitField3;
            public IntPtr dshSection;
            public int dsOffset;
        }

        [DllImport("gdi32.dll", EntryPoint = "GetObject")]
        private static extern int GetObjectDIBSection(IntPtr hObject, int nCount, ref DIBSECTION lpObject);
    }
}
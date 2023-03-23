//------------------------------------------------------------------------------
// <copyright file="Gallery.cs" company="Alton X Lam">
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
using System.Diagnostics;
using System.Drawing;
using System.Drawing.IconLib;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ExcelDna.Integration;
using ExcelDna.Integration.CustomUI;

namespace ImageMso.Excel
{
    ///<summary>Image gallery of unqiue ImageMso icons gathered by a composite of multiple sources.</summary>
    public partial class Gallery : Form, IExcelAddIn
    {
        ///<summary>ComVisible class for Ribbon call back and event handling methods.</summary>
        [ComVisible(true)]
        public class Ribbon : ExcelRibbon
        {
            ///<summary>Handles the ribbon control button OnClick Event. Activates the existing gallery or builds a new gallery.</summary>
            public void OnAction(IRibbonControl control)
            {
                if (Default == null || Default.IsDisposed) (Default = new Gallery()).Show();
                else Default.Activate();
            }

            ///<summary>Handles the ribbon control button GetSuperTip Callback. Returns the supertip for the ribbon control button.</summary>
            public string GetSuperTip(IRibbonControl control)
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                return attributes.Length == 0 ? string.Empty : ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        ///<summary>Underlines the hotkey letter for tool strip menu items.</summary>
        private class HotkeyMenuStripRenderer : ToolStripProfessionalRenderer
        {
            public HotkeyMenuStripRenderer() : base() { }
            public HotkeyMenuStripRenderer(ProfessionalColorTable table) : base(table) { }

            protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
            {
                e.TextFormat &= ~TextFormatFlags.HidePrefix;
                base.OnRenderItemText(e);
            }
        }

        ///<summary>Default instance for static referencing.</summary>
        public static Gallery Default { get; private set; }
        private Images imageMso = Images.Default;
        private KeyEventArgs key = null; // Saves the key state between KeyDown and KeyUp events.
        private string dimensions = string.Empty;
        private string expression = string.Empty;

        /// <summary>Initializes a new instance of the ImageMso.Gallery class.</summary>
        public Gallery()
        {
            InitializeComponent();

            GalleryMenu.Renderer = new HotkeyMenuStripRenderer();

            if (Default == null) Default = this;

            Icons.SmallImageList = new ImageList();
            Icons.LargeImageList = new ImageList();
            Icons.SmallImageList.ImageSize = new Size(16, 16);
            Icons.LargeImageList.ImageSize = new Size(32, 32);
            Icons.SmallImageList.ColorDepth = ColorDepth.Depth32Bit;
            Icons.LargeImageList.ColorDepth = ColorDepth.Depth32Bit;

            Icons.BeginUpdate();
            foreach (string name in imageMso.Names)
            {
                Icons.SmallImageList.Images.Add(name, imageMso[name, 16, 16]);
                Icons.LargeImageList.Images.Add(name, imageMso[name, 32, 32]);
                Icons.Items.Add(name, name, Icons.Items.Count);
            }
            Icons.EndUpdate();

            Small.Checked = Icons.View == View.List;
            Large.Checked = Icons.View == View.LargeIcon;

            using (var image = imageMso["DesignAccentsGallery", 32, 32] ?? imageMso["GroupSmartArtQuickStyles", 32, 32])
                if (image != null) Icon = Icon.FromHandle(image.GetHicon());
            ViewSize.Image = imageMso["ListView", 16, 16];
            Large.Image = imageMso["LargeIcons", 16, 16] ?? imageMso["SmartArtLargerShape", 16, 16];
            Small.Image = imageMso["SmallIcons", 16, 16] ?? imageMso["SmartArtSmallerShape", 16, 16];
            Filter.Image = imageMso["FiltersMenu", 16, 16];
            Clear.Image = imageMso["FilterClearAllFilters", 16, 16];
            CopyPicture.Image = imageMso["CopyPicture", 16, 16];
            CopyText.Image = imageMso["Copy", 16, 16];
            SelectAll.Image = imageMso["SelectAll", 16, 16];
            Dimensions.Image = imageMso["PicturePropertiesSize", 16, 16] ?? imageMso["SizeAndPositionWindow", 16, 16];
            SaveAs.Image = imageMso["PictureFormatDialog", 16, 16];
            Save.Image = imageMso["FileSave", 16, 16];
            Bmp.Image = imageMso["SaveAsBmp", 16, 16];
            Gif.Image = imageMso["SaveAsGif", 16, 16];
            Jpg.Image = imageMso["SaveAsJpg", 16, 16];
            Png.Image = imageMso["SaveAsPng", 16, 16];
            Tif.Image = imageMso["SaveAsTiff", 16, 16];
            Ico.Image = imageMso["InsertImageHtmlTag", 16, 16];
            Background.Image = imageMso["FontColorCycle", 16, 16];
            ExportAs.Image = imageMso["SlideShowResolutionGallery", 16, 16];
            Export.Image = imageMso["ArrangeBySize", 16, 16];
            Support.Image = imageMso["Help", 16, 16];
            Information.Image = imageMso["Info", 16, 16];

            Background.Text = string.Format(Background.Text, Palette.Color.Name);
        }

        ///<summary>Runs when the Excel Add-In is attached. Renders the gallery and brings the form into focus.</summary>
        public void AutoOpen()
        {
            this.Show();
            this.Activate();
        }

        ///<summary>Runs when the Excel Add-In is detached. Cleans up resources no longer being used.</summary>
        public void AutoClose()
        {
        }

        private void Gallery_Disposed(object sender, System.EventArgs e)
        {
            DestroyIcon(Icon.Handle);
        }

        private void Gallery_KeyDown(object sender, KeyEventArgs e)
        {
            key = e;
        }

        private void Gallery_KeyUp(object sender, KeyEventArgs e)
        {
            if (key != null && key.Alt)
            {
                GalleryMenu.Show(RectangleToScreen(Icons.ClientRectangle).Left,
                    RectangleToScreen(Icons.ClientRectangle).Top);
                e.SuppressKeyPress = true;
            }
            key = e;
        }

        private void Icons_ItemDrag(object sender, ItemDragEventArgs e)
        {   // The MemoryStream containing the image must cycle through the clipboard to Drag & Drop correctly.
            // Direct approaches lost the alpha channel (background transparency) or refused to drop.
            CopyPicture_Click(sender, e);
            Icons.DoDragDrop(Clipboard.GetDataObject(), DragDropEffects.All);
        }

        private void Icons_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            CopyPicture.Enabled = Icons.FocusedItem.Selected;
            CopyText.Enabled = Icons.SelectedItems.Count > 0;
            Export.Enabled = Icons.SelectedItems.Count > 0;
            Save.Enabled = Icons.SelectedItems.Count > 0;
        }

        private void ViewSize_Check(object sender, EventArgs e)
        {
            if (sender == Large && Icons.View != View.LargeIcon)
            {
                Icons.View = View.LargeIcon;
                Copy32px.PerformClick();
            }
            if (sender == Small && Icons.View != View.List)
            {
                Icons.View = View.List;
                Copy16px.PerformClick();
            }
            Large.Checked = Icons.View == View.LargeIcon;
            Small.Checked = Icons.View == View.List;
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in Icons.Items) i.Selected = true;
        }

        private void SetFilters_GotFocus(object sender, EventArgs e)
        {
            expression = SetFilters.Text;
        }

        private void SetFilters_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SetFilters_LostFocus(sender, e);
        }

        private void SetFilters_LostFocus(object sender, EventArgs e)
        {
            SetFilters.Text = SetFilters.Text.Trim();
            if (SetFilters.AutoCompleteCustomSource == null) 
                SetFilters.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            if (!SetFilters.AutoCompleteCustomSource.Contains(SetFilters.Text))
                SetFilters.AutoCompleteCustomSource.Add(SetFilters.Text);
            if (SetFilters.Text != expression)
            {
                expression = SetFilters.Text;

                int i = 0;
                string[] split = expression.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (split.Length == 0) split = new string[] { string.Empty };
                string[][] filters = new string[split.Length][];
                foreach (string filter in split)
                    filters[i++] = filter.Trim().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                Clear.Enabled = SetFilters.Text.Length > 0;
                Filter.Checked = SetFilters.Text.Length > 0;
                Icons.Items.Clear();
                Icons.BeginUpdate();
                foreach (string name in imageMso.Names)
                {
                    bool any = false;
                    foreach (string[] group in filters)
                    {
                        bool all = true;
                        foreach (string filter in group)
                            all &= name.ToLowerInvariant().Contains(filter.ToLowerInvariant().Trim());
                        any |= all;
                    }
                    if (any) Icons.Items.Add(name, name, imageMso.Names.IndexOf(name));
                }
                Icons.EndUpdate();
                if (Icons.FocusedItem == null && Icons.Items.Count > 0)
                    Icons.FocusedItem = Icons.Items[0];
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if (Filter.Checked)
            {
                SetFilters.Clear();
                SetFilters_LostFocus(sender, e);
            }
        }

        private void CopyPicture_Click(object sender, EventArgs e)
        {
            short[] dims = Parse(Pixels.Text.ToLowerInvariant().Trim());
            var image = imageMso[Icons.FocusedItem.Name, dims[0], dims[1]];
            //Clipboard.SetImage(image); // Loses alpha channel (background transparency). Use MemoryStream and SetData instead.
            using (var stream = new MemoryStream())
            {
                image.Save(stream, ImageFormat.Png);
                Clipboard.SetData("PNG", stream);
            }
        }

        private void CopyText_Click(object sender, EventArgs e)
        {
            string value = string.Empty;
            foreach (ListViewItem i in Icons.Items)
                if (i.Selected) value += i.Text + Environment.NewLine;
            if (value.Length > 0) Clipboard.SetText(value.Trim());
        }

        private void Dimensions_Check(object sender, EventArgs e)
        {
            Pixels.Text = ((ToolStripMenuItem)sender).Text.Replace("&", string.Empty);
            foreach (ToolStripItem i in Dimensions.DropDownItems)
                if (i.GetType() == typeof(ToolStripMenuItem))
                    ((ToolStripMenuItem)i).Checked = i == sender;
        }

        private void Pixels_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ToolStripItem i in Dimensions.DropDownItems)
                if (i.GetType() == typeof(ToolStripMenuItem))
                    ((ToolStripMenuItem)i).Checked = Pixels.Text == ((ToolStripMenuItem)i).Text.Replace("&", string.Empty);
        }

        private void Pixels_GotFocus(object sender, EventArgs e)
        {
            dimensions = Pixels.Text;
        }

        private void Pixels_LostFocus(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Pixels.Text.ToLowerInvariant().Trim(), @"^\d{2,3}\s*(x)?\s*(\d{2,3})?$"))
            {
                short[] dims = Parse(Pixels.Text.ToLowerInvariant().Trim());
                if (Array.TrueForAll(dims, v => v >= 16 && v <= 128) &&
                    Array.TrueForAll(dims, v => v == dims[0]))
                    if (dims.Length == 1) dimensions = dims[0] + " x " + dims[0];
                    else if (dims.Length == 2) dimensions = dims[0] + " x " + dims[1];
            }
            Pixels.Text = dimensions;
            Pixels_SelectedIndexChanged(sender, e);
        }

        private void Pixels_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Pixels_LostFocus(sender, e);
        }

        private void Export_Click(object sender, EventArgs e)
        {
            if (Icons.SelectedItems.Count > 0 && SaveTo.ShowDialog() == DialogResult.OK)
            {
                foreach (ListViewItem i in Icons.SelectedItems)
                {
                    SingleIcon icon = (new MultiIcon()).Add(i.Name);
                    foreach (ToolStripItem d in ExportAs.DropDownItems)
                        if (d.GetType() == typeof(ToolStripMenuItem) && ((ToolStripMenuItem)d).Checked)
                        {
                            short[] dims = Parse(d.Text.Replace("&", string.Empty).ToLowerInvariant().Trim());
                            icon.Add(imageMso[i.Name, dims[0], dims[1]]);
                        }
                    icon.Save(Path.Combine(SaveTo.SelectedPath, string.Format("{0}.{1}", i.Name, "ico")));
                    DestroyIcon(icon.Icon.Handle);
                }
                MessageBox.Show("Export Complete.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Size_Check(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked ^= true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            short[] dims = Parse(Pixels.Text.ToLowerInvariant().Trim());
            if (Icons.SelectedItems.Count > 0 && SaveTo.ShowDialog() == DialogResult.OK)
            {
                foreach (ListViewItem i in Icons.SelectedItems)
                    foreach (ToolStripItem f in SaveAs.DropDownItems)
                        if (f.GetType() == typeof(ToolStripMenuItem) && ((ToolStripMenuItem)f).Checked)
                        {
                            Bitmap image;
                            var format = Format(f.Name);
                            if (format == ImageFormat.Bmp || 
                                format == ImageFormat.Gif || format == ImageFormat.Jpeg)
                            {   // Formats don't support background transparency
                                image = new Bitmap(dims[0], dims[1]);
                                Graphics canvas = Graphics.FromImage(image);
                                canvas.Clear(Palette.Color);
                                canvas.DrawImage(imageMso[i.Name, dims[0], dims[1]], 0, 0);
                            }
                            else image = imageMso[i.Name, dims[0], dims[1]];

                            string filename = Path.Combine(SaveTo.SelectedPath,
                                string.Format("{0}.{1}", i.Name, f.Name.ToLowerInvariant()));
                            if (format == ImageFormat.Icon)
                            {
                                SingleIcon icon = (new MultiIcon()).Add(i.Name);
                                icon.Add(image);
                                icon.Save(filename);
                                DestroyIcon(icon.Icon.Handle);
                            }
                            else image.Save(filename, format);
                        }
                MessageBox.Show("Save Complete.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Format_Check(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked ^= true;
        }

        private void Background_Click(object sender, EventArgs e)
        {
            string text = Background.Text.Replace(Palette.Color.Name, "{0}");
            Palette.ShowDialog();
            Background.Text = string.Format(text, Palette.Color.Name);
        }

        private void Support_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This action will launch the web browser and open the support website.", "Help",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) Process.Start(imageMso.Help);
        }

        private void Information_Click(object sender, EventArgs e)
        {
            (new About()).ShowDialog();
        }

        ///<summary>Translates the 3 or 4 letter image file extension into a System.Drawing.ImageFormat constant.</summary>
        private ImageFormat Format(string extension)
        {
            switch (extension.ToLowerInvariant())
            {
                case "bmp": return ImageFormat.Bmp;
                case "emf": return ImageFormat.Emf;
                case "gif": return ImageFormat.Gif;
                case "ico": return ImageFormat.Icon;
                case "jpeg": return ImageFormat.Jpeg;
                case "jpg": return ImageFormat.Jpeg;
                case "exif": return ImageFormat.Exif;
                case "png": return ImageFormat.Png;
                case "tif": return ImageFormat.Tiff;
                case "tiff": return ImageFormat.Tiff;
                case "wmf": return ImageFormat.Wmf;
                default: return null;
            }
        }

        ///<summary>Parses n dimension sizes from a string in the form "D1 x D2 x … x Dn" to a <see cref="System.Int16" /> array.</summary>
        private short[] Parse(string pixels)
        {
            return Array.ConvertAll(pixels.Split("x".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries), s => Int16.Parse(s.Trim()));
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private extern static bool DestroyIcon(IntPtr handle);
    }
}

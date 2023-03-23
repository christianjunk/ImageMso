//------------------------------------------------------------------------------
// <copyright file="Gallery.Designer.cs" company="Alton X Lam">
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
// claim that you wrote the original software. If you use this software
// in a product, an acknowledgment in the product documentation would be
// appreciated but is not required.
//
// 2. Altered source versions must be plainly marked as such, and must not be
// misrepresented as being the original software.
//
// 3. This notice may not be removed or altered from any source distribution.
//
// Alton X Lam
// https://www.facebook.com/AltonXL
// https://www.codeplex.com/site/users/view/AltonXL
// </copyright>
//------------------------------------------------------------------------------

namespace ImageMso.Excel
{
    partial class Gallery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Icons = new System.Windows.Forms.ListView();
            this.GalleryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewSize = new System.Windows.Forms.ToolStripMenuItem();
            this.Large = new System.Windows.Forms.ToolStripMenuItem();
            this.Small = new System.Windows.Forms.ToolStripMenuItem();
            this.Filter = new System.Windows.Forms.ToolStripMenuItem();
            this.SetFilters = new System.Windows.Forms.ToolStripTextBox();
            this.Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.Dimensions = new System.Windows.Forms.ToolStripMenuItem();
            this.Pixels = new System.Windows.Forms.ToolStripComboBox();
            this.DimensionsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.Copy16px = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy24px = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy32px = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy48px = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy64px = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy128px = new System.Windows.Forms.ToolStripMenuItem();
            this.TopSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.CopyPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyText = new System.Windows.Forms.ToolStripMenuItem();
            this.MiddleSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ExportAs = new System.Windows.Forms.ToolStripMenuItem();
            this.Export = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.Export16px = new System.Windows.Forms.ToolStripMenuItem();
            this.Export24px = new System.Windows.Forms.ToolStripMenuItem();
            this.Export32px = new System.Windows.Forms.ToolStripMenuItem();
            this.Export48px = new System.Windows.Forms.ToolStripMenuItem();
            this.Export64px = new System.Windows.Forms.ToolStripMenuItem();
            this.Export128px = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.Bmp = new System.Windows.Forms.ToolStripMenuItem();
            this.Gif = new System.Windows.Forms.ToolStripMenuItem();
            this.Jpg = new System.Windows.Forms.ToolStripMenuItem();
            this.Png = new System.Windows.Forms.ToolStripMenuItem();
            this.Tif = new System.Windows.Forms.ToolStripMenuItem();
            this.Ico = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.Background = new System.Windows.Forms.ToolStripMenuItem();
            this.Support = new System.Windows.Forms.ToolStripMenuItem();
            this.Information = new System.Windows.Forms.ToolStripMenuItem();
            this.Palette = new System.Windows.Forms.ColorDialog();
            this.SaveTo = new System.Windows.Forms.FolderBrowserDialog();
            this.GalleryMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Icons
            // 
            this.Icons.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Icons.ContextMenuStrip = this.GalleryMenu;
            this.Icons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Icons.Location = new System.Drawing.Point(0, 0);
            this.Icons.Name = "Icons";
            this.Icons.Size = new System.Drawing.Size(584, 362);
            this.Icons.TabIndex = 0;
            this.Icons.UseCompatibleStateImageBehavior = false;
            this.Icons.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.Icons_ItemDrag);
            this.Icons.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.Icons_ItemSelectionChanged);
            // 
            // GalleryMenu
            // 
            this.GalleryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewSize,
            this.Filter,
            this.Dimensions,
            this.TopSeparator,
            this.CopyPicture,
            this.CopyText,
            this.MiddleSeparator,
            this.SelectAll,
            this.BottomSeparator,
            this.ExportAs,
            this.SaveAs,
            this.Support,
            this.Information});
            this.GalleryMenu.Name = "MenuStrip";
            this.GalleryMenu.Size = new System.Drawing.Size(195, 264);
            // 
            // ViewSize
            // 
            this.ViewSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Large,
            this.Small});
            this.ViewSize.Name = "ViewSize";
            this.ViewSize.Size = new System.Drawing.Size(194, 22);
            this.ViewSize.Text = "&View";
            // 
            // Large
            // 
            this.Large.Name = "Large";
            this.Large.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.Large.Size = new System.Drawing.Size(179, 22);
            this.Large.Text = "&Large icons";
            this.Large.Click += new System.EventHandler(this.ViewSize_Check);
            // 
            // Small
            // 
            this.Small.Name = "Small";
            this.Small.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.Small.Size = new System.Drawing.Size(179, 22);
            this.Small.Text = "&Small icons";
            this.Small.Click += new System.EventHandler(this.ViewSize_Check);
            // 
            // Filter
            // 
            this.Filter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetFilters,
            this.Clear});
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(194, 22);
            this.Filter.Text = "&Filter";
            this.Filter.ToolTipText = "Filter the Gallery so it is easier to find items.";
            // 
            // SetFilters
            // 
            this.SetFilters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SetFilters.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SetFilters.Name = "SetFilters";
            this.SetFilters.Size = new System.Drawing.Size(100, 23);
            this.SetFilters.ToolTipText = "Filter the Gallery by keywords separated by spaces\r\nand keyword groups separated " +
    "by commas.";
            this.SetFilters.GotFocus += new System.EventHandler(this.SetFilters_GotFocus);
            this.SetFilters.LostFocus += new System.EventHandler(this.SetFilters_LostFocus);
            this.SetFilters.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SetFilters_KeyDown);
            // 
            // Clear
            // 
            this.Clear.Enabled = false;
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(160, 22);
            this.Clear.Text = "Cl&ear";
            this.Clear.ToolTipText = "Clear the filter for the entire Gallery.";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Dimensions
            // 
            this.Dimensions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pixels,
            this.DimensionsSeparator,
            this.Copy16px,
            this.Copy24px,
            this.Copy32px,
            this.Copy48px,
            this.Copy64px,
            this.Copy128px});
            this.Dimensions.Name = "Dimensions";
            this.Dimensions.Size = new System.Drawing.Size(194, 22);
            this.Dimensions.Text = "&Dimensions";
            this.Dimensions.ToolTipText = "Set dimensions for Copy, Drag, Drop and Save.";
            // 
            // Pixels
            // 
            this.Pixels.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Pixels.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Pixels.Items.AddRange(new object[] {
            "16 x 16",
            "24 x 24",
            "32 x 32",
            "48 x 48",
            "64 x 64",
            "128 x 128"});
            this.Pixels.Name = "Pixels";
            this.Pixels.Size = new System.Drawing.Size(121, 23);
            this.Pixels.Text = "32 x 32";
            this.Pixels.SelectedIndexChanged += new System.EventHandler(this.Pixels_SelectedIndexChanged);
            this.Pixels.GotFocus += new System.EventHandler(this.Pixels_GotFocus);
            this.Pixels.LostFocus += new System.EventHandler(this.Pixels_LostFocus);
            this.Pixels.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pixels_KeyDown);
            // 
            // DimensionsSeparator
            // 
            this.DimensionsSeparator.Name = "DimensionsSeparator";
            this.DimensionsSeparator.Size = new System.Drawing.Size(178, 6);
            // 
            // Copy16px
            // 
            this.Copy16px.Name = "Copy16px";
            this.Copy16px.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.Copy16px.Size = new System.Drawing.Size(181, 22);
            this.Copy16px.Text = "&16 x 16";
            this.Copy16px.Click += new System.EventHandler(this.Dimensions_Check);
            // 
            // Copy24px
            // 
            this.Copy24px.Name = "Copy24px";
            this.Copy24px.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.Copy24px.Size = new System.Drawing.Size(181, 22);
            this.Copy24px.Text = "&24 x 24";
            this.Copy24px.Click += new System.EventHandler(this.Dimensions_Check);
            // 
            // Copy32px
            // 
            this.Copy32px.Checked = true;
            this.Copy32px.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Copy32px.Name = "Copy32px";
            this.Copy32px.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.Copy32px.Size = new System.Drawing.Size(181, 22);
            this.Copy32px.Text = "&32 x 32";
            this.Copy32px.Click += new System.EventHandler(this.Dimensions_Check);
            // 
            // Copy48px
            // 
            this.Copy48px.Name = "Copy48px";
            this.Copy48px.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.Copy48px.Size = new System.Drawing.Size(181, 22);
            this.Copy48px.Text = "&48 x 48";
            this.Copy48px.Click += new System.EventHandler(this.Dimensions_Check);
            // 
            // Copy64px
            // 
            this.Copy64px.Name = "Copy64px";
            this.Copy64px.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.Copy64px.Size = new System.Drawing.Size(181, 22);
            this.Copy64px.Text = "&64 x 64";
            this.Copy64px.Click += new System.EventHandler(this.Dimensions_Check);
            // 
            // Copy128px
            // 
            this.Copy128px.Name = "Copy128px";
            this.Copy128px.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D8)));
            this.Copy128px.Size = new System.Drawing.Size(181, 22);
            this.Copy128px.Text = "12&8 x 128";
            this.Copy128px.Click += new System.EventHandler(this.Dimensions_Check);
            // 
            // TopSeparator
            // 
            this.TopSeparator.Name = "TopSeparator";
            this.TopSeparator.Size = new System.Drawing.Size(191, 6);
            // 
            // CopyPicture
            // 
            this.CopyPicture.Enabled = false;
            this.CopyPicture.Name = "CopyPicture";
            this.CopyPicture.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyPicture.Size = new System.Drawing.Size(194, 22);
            this.CopyPicture.Text = "&Copy as Image";
            this.CopyPicture.ToolTipText = "Copy the picture Selection and put it on the Clipboard.";
            this.CopyPicture.Click += new System.EventHandler(this.CopyPicture_Click);
            // 
            // CopyText
            // 
            this.CopyText.Enabled = false;
            this.CopyText.Name = "CopyText";
            this.CopyText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.CopyText.Size = new System.Drawing.Size(194, 22);
            this.CopyText.Text = "Copy as &Text";
            this.CopyText.ToolTipText = "Copy the Selection names and put it on the Clipboard.";
            this.CopyText.Click += new System.EventHandler(this.CopyText_Click);
            // 
            // MiddleSeparator
            // 
            this.MiddleSeparator.Name = "MiddleSeparator";
            this.MiddleSeparator.Size = new System.Drawing.Size(191, 6);
            // 
            // SelectAll
            // 
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAll.Size = new System.Drawing.Size(194, 22);
            this.SelectAll.Text = "Select &all";
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // BottomSeparator
            // 
            this.BottomSeparator.Name = "BottomSeparator";
            this.BottomSeparator.Size = new System.Drawing.Size(191, 6);
            // 
            // ExportAs
            // 
            this.ExportAs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Export,
            this.ExportSeparator,
            this.Export16px,
            this.Export24px,
            this.Export32px,
            this.Export48px,
            this.Export64px,
            this.Export128px});
            this.ExportAs.Name = "ExportAs";
            this.ExportAs.Size = new System.Drawing.Size(194, 22);
            this.ExportAs.Text = "E&xport as Multi-Size";
            this.ExportAs.ToolTipText = "Export the Selection to multi-sized icon files. Select\r\nmany sizes for export int" +
    "o a single icon file for each\r\nimage.";
            // 
            // Export
            // 
            this.Export.Enabled = false;
            this.Export.Name = "Export";
            this.Export.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Export.Size = new System.Drawing.Size(193, 22);
            this.Export.Text = "E&xport";
            this.Export.ToolTipText = "Export the Selection to multi-sized icon files.";
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // ExportSeparator
            // 
            this.ExportSeparator.Name = "ExportSeparator";
            this.ExportSeparator.Size = new System.Drawing.Size(190, 6);
            // 
            // Export16px
            // 
            this.Export16px.Checked = true;
            this.Export16px.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Export16px.Name = "Export16px";
            this.Export16px.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D1)));
            this.Export16px.Size = new System.Drawing.Size(193, 22);
            this.Export16px.Text = "&16 x 16";
            this.Export16px.Click += new System.EventHandler(this.Size_Check);
            // 
            // Export24px
            // 
            this.Export24px.Name = "Export24px";
            this.Export24px.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D2)));
            this.Export24px.Size = new System.Drawing.Size(193, 22);
            this.Export24px.Text = "&24 x 24";
            this.Export24px.Click += new System.EventHandler(this.Size_Check);
            // 
            // Export32px
            // 
            this.Export32px.Checked = true;
            this.Export32px.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Export32px.Name = "Export32px";
            this.Export32px.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D3)));
            this.Export32px.Size = new System.Drawing.Size(193, 22);
            this.Export32px.Text = "&32 x 32";
            this.Export32px.Click += new System.EventHandler(this.Size_Check);
            // 
            // Export48px
            // 
            this.Export48px.Name = "Export48px";
            this.Export48px.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D4)));
            this.Export48px.Size = new System.Drawing.Size(193, 22);
            this.Export48px.Text = "&48 x 48";
            this.Export48px.Click += new System.EventHandler(this.Size_Check);
            // 
            // Export64px
            // 
            this.Export64px.Name = "Export64px";
            this.Export64px.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D6)));
            this.Export64px.Size = new System.Drawing.Size(193, 22);
            this.Export64px.Text = "&64 x 64";
            this.Export64px.Click += new System.EventHandler(this.Size_Check);
            // 
            // Export128px
            // 
            this.Export128px.Name = "Export128px";
            this.Export128px.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D8)));
            this.Export128px.Size = new System.Drawing.Size(193, 22);
            this.Export128px.Text = "12&8 x 128";
            this.Export128px.Click += new System.EventHandler(this.Size_Check);
            // 
            // SaveAs
            // 
            this.SaveAs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save,
            this.SaveSeparator,
            this.Bmp,
            this.Gif,
            this.Jpg,
            this.Png,
            this.Tif,
            this.Ico,
            this.FormatSeparator,
            this.Background});
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(194, 22);
            this.SaveAs.Text = "&Save as Image";
            this.SaveAs.ToolTipText = "Save the Selection as image files.  Select many formats\r\nto save into a each imag" +
    "e as.";
            // 
            // Save
            // 
            this.Save.Enabled = false;
            this.Save.Name = "Save";
            this.Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Save.Size = new System.Drawing.Size(324, 22);
            this.Save.Text = "&Save";
            this.Save.ToolTipText = "Save the Selection as image files.";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveSeparator
            // 
            this.SaveSeparator.Name = "SaveSeparator";
            this.SaveSeparator.Size = new System.Drawing.Size(321, 6);
            // 
            // Bmp
            // 
            this.Bmp.Name = "Bmp";
            this.Bmp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.Bmp.Size = new System.Drawing.Size(324, 22);
            this.Bmp.Text = "&Bitmap (BMP)";
            this.Bmp.Click += new System.EventHandler(this.Format_Check);
            // 
            // Gif
            // 
            this.Gif.Name = "Gif";
            this.Gif.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.Gif.Size = new System.Drawing.Size(324, 22);
            this.Gif.Text = "&Graphics Interchange Format (GIF)";
            this.Gif.Click += new System.EventHandler(this.Format_Check);
            // 
            // Jpg
            // 
            this.Jpg.Name = "Jpg";
            this.Jpg.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.Jpg.Size = new System.Drawing.Size(324, 22);
            this.Jpg.Text = "&Joint Photographic Experts Group (JPEG)";
            this.Jpg.Click += new System.EventHandler(this.Format_Check);
            // 
            // Png
            // 
            this.Png.Checked = true;
            this.Png.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Png.Name = "Png";
            this.Png.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.Png.Size = new System.Drawing.Size(324, 22);
            this.Png.Text = "&Portable Network Graphics (PNG)";
            this.Png.Click += new System.EventHandler(this.Format_Check);
            // 
            // Tif
            // 
            this.Tif.Name = "Tif";
            this.Tif.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.Tif.Size = new System.Drawing.Size(324, 22);
            this.Tif.Text = "&Tagged Image File Format (TIFF)";
            this.Tif.Click += new System.EventHandler(this.Format_Check);
            // 
            // Ico
            // 
            this.Ico.Name = "Ico";
            this.Ico.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.Ico.Size = new System.Drawing.Size(324, 22);
            this.Ico.Text = "Windows &Icon Image (ICO)";
            this.Ico.Click += new System.EventHandler(this.Format_Check);
            // 
            // FormatSeparator
            // 
            this.FormatSeparator.Name = "FormatSeparator";
            this.FormatSeparator.Size = new System.Drawing.Size(321, 6);
            // 
            // Background
            // 
            this.Background.Name = "Background";
            this.Background.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Background.Size = new System.Drawing.Size(324, 22);
            this.Background.Text = "&Opaque Background Color ({0})";
            this.Background.ToolTipText = "Set the background color for opaque image\r\nformats that do not support transparen" +
    "cy.";
            this.Background.Click += new System.EventHandler(this.Background_Click);
            // 
            // Support
            // 
            this.Support.Name = "Support";
            this.Support.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.Support.ShowShortcutKeys = false;
            this.Support.Size = new System.Drawing.Size(194, 22);
            this.Support.Text = "&Help";
            this.Support.Click += new System.EventHandler(this.Support_Click);
            // 
            // Information
            // 
            this.Information.Name = "Information";
            this.Information.ShowShortcutKeys = false;
            this.Information.Size = new System.Drawing.Size(194, 22);
            this.Information.Text = "&About";
            this.Information.Click += new System.EventHandler(this.Information_Click);
            // 
            // Palette
            // 
            this.Palette.AnyColor = true;
            this.Palette.Color = System.Drawing.Color.White;
            this.Palette.FullOpen = true;
            this.Palette.ShowHelp = true;
            // 
            // Gallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.ContextMenuStrip = this.GalleryMenu;
            this.Controls.Add(this.Icons);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "Gallery";
            this.Text = "Microsoft Office Icons – ImageMSO Gallery";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gallery_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Gallery_KeyUp);
            this.Disposed += new System.EventHandler(this.Gallery_Disposed);
            this.GalleryMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.ListView Icons;
        private System.Windows.Forms.ContextMenuStrip GalleryMenu;
        private System.Windows.Forms.ToolStripMenuItem ViewSize;
        private System.Windows.Forms.ToolStripMenuItem Large;
        private System.Windows.Forms.ToolStripMenuItem Small;
        private System.Windows.Forms.ToolStripMenuItem Filter;
        private System.Windows.Forms.ToolStripTextBox SetFilters;
        private System.Windows.Forms.ToolStripMenuItem Clear;
        private System.Windows.Forms.ToolStripSeparator TopSeparator;
        private System.Windows.Forms.ToolStripMenuItem CopyPicture;
        private System.Windows.Forms.ToolStripMenuItem CopyText;
        private System.Windows.Forms.ToolStripSeparator MiddleSeparator;
        private System.Windows.Forms.ToolStripMenuItem SelectAll;
        private System.Windows.Forms.ToolStripSeparator BottomSeparator;
        private System.Windows.Forms.ToolStripMenuItem Dimensions;
        private System.Windows.Forms.ToolStripComboBox Pixels;
        private System.Windows.Forms.ToolStripSeparator DimensionsSeparator;
        private System.Windows.Forms.ToolStripMenuItem Copy16px;
        private System.Windows.Forms.ToolStripMenuItem Copy24px;
        private System.Windows.Forms.ToolStripMenuItem Copy32px;
        private System.Windows.Forms.ToolStripMenuItem Copy48px;
        private System.Windows.Forms.ToolStripMenuItem Copy64px;
        private System.Windows.Forms.ToolStripMenuItem Copy128px;
        private System.Windows.Forms.ToolStripMenuItem SaveAs;
        private System.Windows.Forms.ToolStripMenuItem Bmp;
        private System.Windows.Forms.ToolStripMenuItem Gif;
        private System.Windows.Forms.ToolStripMenuItem Jpg;
        private System.Windows.Forms.ToolStripMenuItem Png;
        private System.Windows.Forms.ToolStripMenuItem Tif;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Background;
        private System.Windows.Forms.ToolStripSeparator FormatSeparator;
        private System.Windows.Forms.ToolStripMenuItem Ico;
        private System.Windows.Forms.ColorDialog Palette;
        private System.Windows.Forms.FolderBrowserDialog SaveTo;
        private System.Windows.Forms.ToolStripMenuItem ExportAs;
        private System.Windows.Forms.ToolStripMenuItem Export16px;
        private System.Windows.Forms.ToolStripMenuItem Export24px;
        private System.Windows.Forms.ToolStripMenuItem Export32px;
        private System.Windows.Forms.ToolStripMenuItem Export48px;
        private System.Windows.Forms.ToolStripMenuItem Export64px;
        private System.Windows.Forms.ToolStripMenuItem Export128px;
        private System.Windows.Forms.ToolStripMenuItem Export;
        private System.Windows.Forms.ToolStripSeparator ExportSeparator;
        private System.Windows.Forms.ToolStripSeparator SaveSeparator;
        private System.Windows.Forms.ToolStripMenuItem Support;
        private System.Windows.Forms.ToolStripMenuItem Information;
    }
}
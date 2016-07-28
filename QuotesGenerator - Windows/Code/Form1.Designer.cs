/* 
    Copyright 2016 Jean-Pierre Hotz
Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
 */

namespace TumblrMaterialThemeQuotesGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveAsProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeneratePreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenInExtBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ErrorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NoteLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.GeneratedCodeBox = new System.Windows.Forms.RichTextBox();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.MixQuotesButton = new System.Windows.Forms.Button();
            this.DeleteSelectedQuoteButton = new System.Windows.Forms.Button();
            this.ChangeSelectedQuoteButton = new System.Windows.Forms.Button();
            this.AddQuoteButton = new System.Windows.Forms.Button();
            this.SongLabel = new System.Windows.Forms.Label();
            this.SongTextBox = new System.Windows.Forms.TextBox();
            this.ArtistTextBox = new System.Windows.Forms.TextBox();
            this.QuoteTextBox = new System.Windows.Forms.TextBox();
            this.ArtistLabel = new System.Windows.Forms.Label();
            this.QuoteLabel = new System.Windows.Forms.Label();
            this.QuotesList = new System.Windows.Forms.ListView();
            this.ListViewHeaderQuote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewHeaderArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewHeaderSong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabLayout = new System.Windows.Forms.TabControl();
            this.PreviewTabPage = new System.Windows.Forms.TabPage();
            this.PreviewWebControl = new EO.WebBrowser.WinForm.WebControl();
            this.webView1 = new EO.WebBrowser.WebView();
            this.PreviewSettingsTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PreviewSettingsShowQuotesCheckBox = new System.Windows.Forms.CheckBox();
            this.PreviewSettingsBackgroundStripesCheckBox = new System.Windows.Forms.CheckBox();
            this.PreviewSettingsSlidingHeaderCheckBox = new System.Windows.Forms.CheckBox();
            this.PreviewSettingsEndlessScrollingCheckBox = new System.Windows.Forms.CheckBox();
            this.PreviewSettingsThemeColorComboBox = new System.Windows.Forms.ComboBox();
            this.PreviewSettingsThemeColorLabel = new System.Windows.Forms.Label();
            this.PreviewSettingsAvatarBorderColorButton = new System.Windows.Forms.Button();
            this.PreviewSettingsAvatarBorderColorLabel = new System.Windows.Forms.Label();
            this.PreviewSettingsSecondStripeColorButton = new System.Windows.Forms.Button();
            this.PreviewSettingsSecondStripeColorLabel = new System.Windows.Forms.Label();
            this.PreviewSettingsFirstStripeColoButton = new System.Windows.Forms.Button();
            this.PreviewSettingsFirstStripeColorLabel = new System.Windows.Forms.Label();
            this.PreviewSettingsShowDescriptionCheckBox = new System.Windows.Forms.CheckBox();
            this.PreviewSettingsShowTitleCheckBox = new System.Windows.Forms.CheckBox();
            this.PreviewSettingsShowAvatarCheckBox = new System.Windows.Forms.CheckBox();
            this.PreviewSettingsShowHeaderImageCheckBox = new System.Windows.Forms.CheckBox();
            this.PreviewSettingsBackgroundColorButton = new System.Windows.Forms.Button();
            this.PreviewSettingsBackgroundColorLabel = new System.Windows.Forms.Label();
            this.PreviewSettingsAvatarShapeComboBox = new System.Windows.Forms.ComboBox();
            this.PreviewSettingsAvatarShapeLabel = new System.Windows.Forms.Label();
            this.PreviewSettingsDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.PreviewSettingsDescriptionLabel = new System.Windows.Forms.Label();
            this.PreviewSettingsTitleTextBox = new System.Windows.Forms.TextBox();
            this.PreviewSettingsTitleLabel = new System.Windows.Forms.Label();
            this.PreviewSettingsColorDialog = new System.Windows.Forms.ColorDialog();
            this.MenuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabLayout.SuspendLayout();
            this.PreviewTabPage.SuspendLayout();
            this.PreviewSettingsTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.PreviewToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(1007, 24);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.ToolStripSeparator1,
            this.SaveAsProjectToolStripMenuItem,
            this.GenerateCodeToolStripMenuItem,
            this.ToolStripSeparator2,
            this.ExitProgramToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.NewToolStripMenuItem.Text = "New";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // SaveAsProjectToolStripMenuItem
            // 
            this.SaveAsProjectToolStripMenuItem.Name = "SaveAsProjectToolStripMenuItem";
            this.SaveAsProjectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveAsProjectToolStripMenuItem.Text = "Save as project";
            this.SaveAsProjectToolStripMenuItem.Click += new System.EventHandler(this.SaveAsProjectToolStripMenuItem_Click);
            // 
            // GenerateCodeToolStripMenuItem
            // 
            this.GenerateCodeToolStripMenuItem.Name = "GenerateCodeToolStripMenuItem";
            this.GenerateCodeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.GenerateCodeToolStripMenuItem.Text = "Generate code";
            this.GenerateCodeToolStripMenuItem.Click += new System.EventHandler(this.GenerateCodeToolStripMenuItem_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // ExitProgramToolStripMenuItem
            // 
            this.ExitProgramToolStripMenuItem.Name = "ExitProgramToolStripMenuItem";
            this.ExitProgramToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitProgramToolStripMenuItem.Text = "Exit program";
            this.ExitProgramToolStripMenuItem.Click += new System.EventHandler(this.ExitProgramToolStripMenuItem_Click);
            // 
            // PreviewToolStripMenuItem
            // 
            this.PreviewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GeneratePreviewToolStripMenuItem,
            this.OpenInExtBrowserToolStripMenuItem});
            this.PreviewToolStripMenuItem.Name = "PreviewToolStripMenuItem";
            this.PreviewToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.PreviewToolStripMenuItem.Text = "Preview";
            // 
            // GeneratePreviewToolStripMenuItem
            // 
            this.GeneratePreviewToolStripMenuItem.Name = "GeneratePreviewToolStripMenuItem";
            this.GeneratePreviewToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.GeneratePreviewToolStripMenuItem.Text = "Generate";
            this.GeneratePreviewToolStripMenuItem.Click += new System.EventHandler(this.GeneratePreviewToolStripMenuItem_Click);
            // 
            // OpenInExtBrowserToolStripMenuItem
            // 
            this.OpenInExtBrowserToolStripMenuItem.Name = "OpenInExtBrowserToolStripMenuItem";
            this.OpenInExtBrowserToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.OpenInExtBrowserToolStripMenuItem.Text = "Open in ext. Browser";
            this.OpenInExtBrowserToolStripMenuItem.Click += new System.EventHandler(this.OpenInExtBrowserToolStripMenuItem_Click);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ErrorLabel,
            this.NoteLabel});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 503);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(1007, 22);
            this.StatusStrip1.TabIndex = 2;
            this.StatusStrip1.Text = "statusStrip1";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(39, 17);
            this.ErrorLabel.Text = "Ready";
            // 
            // NoteLabel
            // 
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "xml-Files (*.xml)|*.xml";
            this.OpenFileDialog.Tag = "";
            this.OpenFileDialog.Title = "Select a quotes-file to open";
            // 
            // SaveFileDialog1
            // 
            this.SaveFileDialog1.Filter = "xml-Files (*.xml)|*.xml";
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.GeneratedCodeBox);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(974, 446);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Code";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // GeneratedCodeBox
            // 
            this.GeneratedCodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneratedCodeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GeneratedCodeBox.Location = new System.Drawing.Point(6, 6);
            this.GeneratedCodeBox.Name = "GeneratedCodeBox";
            this.GeneratedCodeBox.ReadOnly = true;
            this.GeneratedCodeBox.Size = new System.Drawing.Size(962, 434);
            this.GeneratedCodeBox.TabIndex = 0;
            this.GeneratedCodeBox.Text = "";
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.MixQuotesButton);
            this.TabPage1.Controls.Add(this.DeleteSelectedQuoteButton);
            this.TabPage1.Controls.Add(this.ChangeSelectedQuoteButton);
            this.TabPage1.Controls.Add(this.AddQuoteButton);
            this.TabPage1.Controls.Add(this.SongLabel);
            this.TabPage1.Controls.Add(this.SongTextBox);
            this.TabPage1.Controls.Add(this.ArtistTextBox);
            this.TabPage1.Controls.Add(this.QuoteTextBox);
            this.TabPage1.Controls.Add(this.ArtistLabel);
            this.TabPage1.Controls.Add(this.QuoteLabel);
            this.TabPage1.Controls.Add(this.QuotesList);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(974, 446);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Quotes";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // MixQuotesButton
            // 
            this.MixQuotesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MixQuotesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MixQuotesButton.Location = new System.Drawing.Point(430, 417);
            this.MixQuotesButton.Name = "MixQuotesButton";
            this.MixQuotesButton.Size = new System.Drawing.Size(99, 23);
            this.MixQuotesButton.TabIndex = 10;
            this.MixQuotesButton.Text = "Mix quotes";
            this.MixQuotesButton.UseVisualStyleBackColor = true;
            this.MixQuotesButton.Click += new System.EventHandler(this.MixQuotesButton_Click);
            // 
            // DeleteSelectedQuoteButton
            // 
            this.DeleteSelectedQuoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteSelectedQuoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteSelectedQuoteButton.Location = new System.Drawing.Point(278, 417);
            this.DeleteSelectedQuoteButton.Name = "DeleteSelectedQuoteButton";
            this.DeleteSelectedQuoteButton.Size = new System.Drawing.Size(146, 23);
            this.DeleteSelectedQuoteButton.TabIndex = 9;
            this.DeleteSelectedQuoteButton.Text = "Delete selected quote";
            this.DeleteSelectedQuoteButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedQuoteButton.Click += new System.EventHandler(this.DeleteSelectedQuoteButton_Click);
            // 
            // ChangeSelectedQuoteButton
            // 
            this.ChangeSelectedQuoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChangeSelectedQuoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangeSelectedQuoteButton.Location = new System.Drawing.Point(119, 417);
            this.ChangeSelectedQuoteButton.Name = "ChangeSelectedQuoteButton";
            this.ChangeSelectedQuoteButton.Size = new System.Drawing.Size(153, 23);
            this.ChangeSelectedQuoteButton.TabIndex = 8;
            this.ChangeSelectedQuoteButton.Text = "Change selected quote";
            this.ChangeSelectedQuoteButton.UseVisualStyleBackColor = true;
            this.ChangeSelectedQuoteButton.Click += new System.EventHandler(this.ChangeSelectedQuoteButton_Click);
            // 
            // AddQuoteButton
            // 
            this.AddQuoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddQuoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddQuoteButton.Location = new System.Drawing.Point(7, 417);
            this.AddQuoteButton.Name = "AddQuoteButton";
            this.AddQuoteButton.Size = new System.Drawing.Size(106, 23);
            this.AddQuoteButton.TabIndex = 7;
            this.AddQuoteButton.Text = "Add quote";
            this.AddQuoteButton.UseVisualStyleBackColor = true;
            this.AddQuoteButton.Click += new System.EventHandler(this.AddQuoteButton_Click);
            // 
            // SongLabel
            // 
            this.SongLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SongLabel.AutoSize = true;
            this.SongLabel.Location = new System.Drawing.Point(10, 393);
            this.SongLabel.Name = "SongLabel";
            this.SongLabel.Size = new System.Drawing.Size(35, 13);
            this.SongLabel.TabIndex = 6;
            this.SongLabel.Text = "Song:";
            // 
            // SongTextBox
            // 
            this.SongTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SongTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SongTextBox.Location = new System.Drawing.Point(87, 391);
            this.SongTextBox.Name = "SongTextBox";
            this.SongTextBox.Size = new System.Drawing.Size(880, 20);
            this.SongTextBox.TabIndex = 5;
            // 
            // ArtistTextBox
            // 
            this.ArtistTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArtistTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ArtistTextBox.Location = new System.Drawing.Point(87, 365);
            this.ArtistTextBox.Name = "ArtistTextBox";
            this.ArtistTextBox.Size = new System.Drawing.Size(881, 20);
            this.ArtistTextBox.TabIndex = 3;
            // 
            // QuoteTextBox
            // 
            this.QuoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuoteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuoteTextBox.Location = new System.Drawing.Point(87, 308);
            this.QuoteTextBox.Multiline = true;
            this.QuoteTextBox.Name = "QuoteTextBox";
            this.QuoteTextBox.Size = new System.Drawing.Size(881, 51);
            this.QuoteTextBox.TabIndex = 1;
            // 
            // ArtistLabel
            // 
            this.ArtistLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ArtistLabel.AutoSize = true;
            this.ArtistLabel.Location = new System.Drawing.Point(10, 367);
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Size = new System.Drawing.Size(33, 13);
            this.ArtistLabel.TabIndex = 4;
            this.ArtistLabel.Text = "Artist:";
            // 
            // QuoteLabel
            // 
            this.QuoteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.QuoteLabel.AutoSize = true;
            this.QuoteLabel.Location = new System.Drawing.Point(10, 310);
            this.QuoteLabel.Name = "QuoteLabel";
            this.QuoteLabel.Size = new System.Drawing.Size(39, 13);
            this.QuoteLabel.TabIndex = 2;
            this.QuoteLabel.Text = "Quote:";
            // 
            // QuotesList
            // 
            this.QuotesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuotesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuotesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListViewHeaderQuote,
            this.ListViewHeaderArtist,
            this.ListViewHeaderSong});
            this.QuotesList.Location = new System.Drawing.Point(7, 7);
            this.QuotesList.MultiSelect = false;
            this.QuotesList.Name = "QuotesList";
            this.QuotesList.Size = new System.Drawing.Size(961, 295);
            this.QuotesList.TabIndex = 0;
            this.QuotesList.UseCompatibleStateImageBehavior = false;
            this.QuotesList.View = System.Windows.Forms.View.Details;
            this.QuotesList.SelectedIndexChanged += new System.EventHandler(this.QuotesList_SelectedIndexChanged);
            // 
            // ListViewHeaderQuote
            // 
            this.ListViewHeaderQuote.Text = "Quote";
            this.ListViewHeaderQuote.Width = 550;
            // 
            // ListViewHeaderArtist
            // 
            this.ListViewHeaderArtist.Text = "Artist";
            this.ListViewHeaderArtist.Width = 200;
            // 
            // ListViewHeaderSong
            // 
            this.ListViewHeaderSong.Text = "Song";
            this.ListViewHeaderSong.Width = 200;
            // 
            // TabLayout
            // 
            this.TabLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabLayout.Controls.Add(this.TabPage1);
            this.TabLayout.Controls.Add(this.TabPage2);
            this.TabLayout.Controls.Add(this.PreviewTabPage);
            this.TabLayout.Controls.Add(this.PreviewSettingsTabPage);
            this.TabLayout.Location = new System.Drawing.Point(13, 28);
            this.TabLayout.Name = "TabLayout";
            this.TabLayout.SelectedIndex = 0;
            this.TabLayout.Size = new System.Drawing.Size(982, 472);
            this.TabLayout.TabIndex = 1;
            // 
            // PreviewTabPage
            // 
            this.PreviewTabPage.Controls.Add(this.PreviewWebControl);
            this.PreviewTabPage.Location = new System.Drawing.Point(4, 22);
            this.PreviewTabPage.Name = "PreviewTabPage";
            this.PreviewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PreviewTabPage.Size = new System.Drawing.Size(974, 446);
            this.PreviewTabPage.TabIndex = 2;
            this.PreviewTabPage.Text = "Preview";
            this.PreviewTabPage.UseVisualStyleBackColor = true;
            // 
            // PreviewWebControl
            // 
            this.PreviewWebControl.BackColor = System.Drawing.Color.White;
            this.PreviewWebControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewWebControl.Location = new System.Drawing.Point(3, 3);
            this.PreviewWebControl.Name = "PreviewWebControl";
            this.PreviewWebControl.Size = new System.Drawing.Size(968, 440);
            this.PreviewWebControl.TabIndex = 0;
            this.PreviewWebControl.Text = "webControl1";
            this.PreviewWebControl.WebView = this.webView1;
            // 
            // PreviewSettingsTabPage
            // 
            this.PreviewSettingsTabPage.Controls.Add(this.panel1);
            this.PreviewSettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.PreviewSettingsTabPage.Name = "PreviewSettingsTabPage";
            this.PreviewSettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PreviewSettingsTabPage.Size = new System.Drawing.Size(974, 446);
            this.PreviewSettingsTabPage.TabIndex = 3;
            this.PreviewSettingsTabPage.Text = "Previews settings";
            this.PreviewSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.PreviewSettingsShowQuotesCheckBox);
            this.panel1.Controls.Add(this.PreviewSettingsBackgroundStripesCheckBox);
            this.panel1.Controls.Add(this.PreviewSettingsSlidingHeaderCheckBox);
            this.panel1.Controls.Add(this.PreviewSettingsEndlessScrollingCheckBox);
            this.panel1.Controls.Add(this.PreviewSettingsThemeColorComboBox);
            this.panel1.Controls.Add(this.PreviewSettingsThemeColorLabel);
            this.panel1.Controls.Add(this.PreviewSettingsAvatarBorderColorButton);
            this.panel1.Controls.Add(this.PreviewSettingsAvatarBorderColorLabel);
            this.panel1.Controls.Add(this.PreviewSettingsSecondStripeColorButton);
            this.panel1.Controls.Add(this.PreviewSettingsSecondStripeColorLabel);
            this.panel1.Controls.Add(this.PreviewSettingsFirstStripeColoButton);
            this.panel1.Controls.Add(this.PreviewSettingsFirstStripeColorLabel);
            this.panel1.Controls.Add(this.PreviewSettingsShowDescriptionCheckBox);
            this.panel1.Controls.Add(this.PreviewSettingsShowTitleCheckBox);
            this.panel1.Controls.Add(this.PreviewSettingsShowAvatarCheckBox);
            this.panel1.Controls.Add(this.PreviewSettingsShowHeaderImageCheckBox);
            this.panel1.Controls.Add(this.PreviewSettingsBackgroundColorButton);
            this.panel1.Controls.Add(this.PreviewSettingsBackgroundColorLabel);
            this.panel1.Controls.Add(this.PreviewSettingsAvatarShapeComboBox);
            this.panel1.Controls.Add(this.PreviewSettingsAvatarShapeLabel);
            this.panel1.Controls.Add(this.PreviewSettingsDescriptionTextBox);
            this.panel1.Controls.Add(this.PreviewSettingsDescriptionLabel);
            this.panel1.Controls.Add(this.PreviewSettingsTitleTextBox);
            this.panel1.Controls.Add(this.PreviewSettingsTitleLabel);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 446);
            this.panel1.TabIndex = 0;
            // 
            // PreviewSettingsShowQuotesCheckBox
            // 
            this.PreviewSettingsShowQuotesCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewSettingsShowQuotesCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviewSettingsShowQuotesCheckBox.Location = new System.Drawing.Point(9, 393);
            this.PreviewSettingsShowQuotesCheckBox.Name = "PreviewSettingsShowQuotesCheckBox";
            this.PreviewSettingsShowQuotesCheckBox.Size = new System.Drawing.Size(959, 17);
            this.PreviewSettingsShowQuotesCheckBox.TabIndex = 23;
            this.PreviewSettingsShowQuotesCheckBox.Text = "Show quotes";
            this.PreviewSettingsShowQuotesCheckBox.UseVisualStyleBackColor = true;
            this.PreviewSettingsShowQuotesCheckBox.CheckedChanged += new System.EventHandler(this.PreviewSettingsShowQuotesCheckBox_CheckedChanged);
            // 
            // PreviewSettingsBackgroundStripesCheckBox
            // 
            this.PreviewSettingsBackgroundStripesCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewSettingsBackgroundStripesCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviewSettingsBackgroundStripesCheckBox.Location = new System.Drawing.Point(9, 369);
            this.PreviewSettingsBackgroundStripesCheckBox.Name = "PreviewSettingsBackgroundStripesCheckBox";
            this.PreviewSettingsBackgroundStripesCheckBox.Size = new System.Drawing.Size(959, 17);
            this.PreviewSettingsBackgroundStripesCheckBox.TabIndex = 22;
            this.PreviewSettingsBackgroundStripesCheckBox.Text = "Background as stripes";
            this.PreviewSettingsBackgroundStripesCheckBox.UseVisualStyleBackColor = true;
            this.PreviewSettingsBackgroundStripesCheckBox.CheckedChanged += new System.EventHandler(this.PreviewSettingsBackgroundStripesCheckBox_CheckedChanged);
            // 
            // PreviewSettingsSlidingHeaderCheckBox
            // 
            this.PreviewSettingsSlidingHeaderCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewSettingsSlidingHeaderCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviewSettingsSlidingHeaderCheckBox.Location = new System.Drawing.Point(9, 346);
            this.PreviewSettingsSlidingHeaderCheckBox.Name = "PreviewSettingsSlidingHeaderCheckBox";
            this.PreviewSettingsSlidingHeaderCheckBox.Size = new System.Drawing.Size(959, 17);
            this.PreviewSettingsSlidingHeaderCheckBox.TabIndex = 21;
            this.PreviewSettingsSlidingHeaderCheckBox.Text = "Sliding header";
            this.PreviewSettingsSlidingHeaderCheckBox.UseVisualStyleBackColor = true;
            this.PreviewSettingsSlidingHeaderCheckBox.CheckedChanged += new System.EventHandler(this.PreviewSettingsSlidingHeaderCheckBox_CheckedChanged);
            // 
            // PreviewSettingsEndlessScrollingCheckBox
            // 
            this.PreviewSettingsEndlessScrollingCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewSettingsEndlessScrollingCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviewSettingsEndlessScrollingCheckBox.Location = new System.Drawing.Point(9, 323);
            this.PreviewSettingsEndlessScrollingCheckBox.Name = "PreviewSettingsEndlessScrollingCheckBox";
            this.PreviewSettingsEndlessScrollingCheckBox.Size = new System.Drawing.Size(959, 17);
            this.PreviewSettingsEndlessScrollingCheckBox.TabIndex = 20;
            this.PreviewSettingsEndlessScrollingCheckBox.Text = "Endless scrolling";
            this.PreviewSettingsEndlessScrollingCheckBox.UseVisualStyleBackColor = true;
            this.PreviewSettingsEndlessScrollingCheckBox.CheckedChanged += new System.EventHandler(this.PreviewSettingsEndlessScrollingCheckBox_CheckedChanged);
            // 
            // PreviewSettingsThemeColorComboBox
            // 
            this.PreviewSettingsThemeColorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewSettingsThemeColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PreviewSettingsThemeColorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviewSettingsThemeColorComboBox.FormattingEnabled = true;
            this.PreviewSettingsThemeColorComboBox.Location = new System.Drawing.Point(223, 296);
            this.PreviewSettingsThemeColorComboBox.Name = "PreviewSettingsThemeColorComboBox";
            this.PreviewSettingsThemeColorComboBox.Size = new System.Drawing.Size(745, 21);
            this.PreviewSettingsThemeColorComboBox.TabIndex = 19;
            this.PreviewSettingsThemeColorComboBox.SelectedIndexChanged += new System.EventHandler(this.PreviewSettingsThemeColorComboBox_SelectedIndexChanged);
            // 
            // PreviewSettingsThemeColorLabel
            // 
            this.PreviewSettingsThemeColorLabel.AutoSize = true;
            this.PreviewSettingsThemeColorLabel.Location = new System.Drawing.Point(6, 299);
            this.PreviewSettingsThemeColorLabel.Name = "PreviewSettingsThemeColorLabel";
            this.PreviewSettingsThemeColorLabel.Size = new System.Drawing.Size(64, 13);
            this.PreviewSettingsThemeColorLabel.TabIndex = 18;
            this.PreviewSettingsThemeColorLabel.Text = "ThemeColor";
            // 
            // PreviewSettingsAvatarBorderColorButton
            // 
            this.PreviewSettingsAvatarBorderColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewSettingsAvatarBorderColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviewSettingsAvatarBorderColorButton.Location = new System.Drawing.Point(223, 266);
            this.PreviewSettingsAvatarBorderColorButton.Name = "PreviewSettingsAvatarBorderColorButton";
            this.PreviewSettingsAvatarBorderColorButton.Size = new System.Drawing.Size(745, 23);
            this.PreviewSettingsAvatarBorderColorButton.TabIndex = 17;
            this.PreviewSettingsAvatarBorderColorButton.Text = "Change color";
            this.PreviewSettingsAvatarBorderColorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PreviewSettingsAvatarBorderColorButton.UseVisualStyleBackColor = true;
            this.PreviewSettingsAvatarBorderColorButton.Click += new System.EventHandler(this.PreviewSettingsAvatarBorderColorButton_Click);
            // 
            // PreviewSettingsAvatarBorderColorLabel
            // 
            this.PreviewSettingsAvatarBorderColorLabel.AutoSize = true;
            this.PreviewSettingsAvatarBorderColorLabel.Location = new System.Drawing.Point(6, 271);
            this.PreviewSettingsAvatarBorderColorLabel.Name = "PreviewSettingsAvatarBorderColorLabel";
            this.PreviewSettingsAvatarBorderColorLabel.Size = new System.Drawing.Size(97, 13);
            this.PreviewSettingsAvatarBorderColorLabel.TabIndex = 16;
            this.PreviewSettingsAvatarBorderColorLabel.Text = "Avatar border color";
            // 
            // PreviewSettingsSecondStripeColorButton
            // 
            this.PreviewSettingsSecondStripeColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewSettingsSecondStripeColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviewSettingsSecondStripeColorButton.Location = new System.Drawing.Point(223, 237);
            this.PreviewSettingsSecondStripeColorButton.Name = "PreviewSettingsSecondStripeColorButton";
            this.PreviewSettingsSecondStripeColorButton.Size = new System.Drawing.Size(745, 23);
            this.PreviewSettingsSecondStripeColorButton.TabIndex = 15;
            this.PreviewSettingsSecondStripeColorButton.Text = "Change color";
            this.PreviewSettingsSecondStripeColorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PreviewSettingsSecondStripeColorButton.UseVisualStyleBackColor = true;
            this.PreviewSettingsSecondStripeColorButton.Click += new System.EventHandler(this.PreviewSettingsSecondStripeColorButton_Click);
            // 
            // PreviewSettingsSecondStripeColorLabel
            // 
            this.PreviewSettingsSecondStripeColorLabel.AutoSize = true;
            this.PreviewSettingsSecondStripeColorLabel.Location = new System.Drawing.Point(6, 242);
            this.PreviewSettingsSecondStripeColorLabel.Name = "PreviewSettingsSecondStripeColorLabel";
            this.PreviewSettingsSecondStripeColorLabel.Size = new System.Drawing.Size(159, 13);
            this.PreviewSettingsSecondStripeColorLabel.TabIndex = 14;
            this.PreviewSettingsSecondStripeColorLabel.Text = "Second Background stripe color";
            // 
            // PreviewSettingsFirstStripeColoButton
            // 
            this.PreviewSettingsFirstStripeColoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewSettingsFirstStripeColoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviewSettingsFirstStripeColoButton.Location = new System.Drawing.Point(223, 207);
            this.PreviewSettingsFirstStripeColoButton.Name = "PreviewSettingsFirstStripeColoButton";
            this.PreviewSettingsFirstStripeColoButton.Size = new System.Drawing.Size(745, 23);
            this.PreviewSettingsFirstStripeColoButton.TabIndex = 13;
            this.PreviewSettingsFirstStripeColoButton.Text = "Change color";
            this.PreviewSettingsFirstStripeColoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PreviewSettingsFirstStripeColoButton.UseVisualStyleBackColor = true;
            this.PreviewSettingsFirstStripeColoButton.Click += new System.EventHandler(this.PreviewSettingsFirstStripeColoButton_Click);
            // 
            // PreviewSettingsFirstStripeColorLabel
            // 
            this.PreviewSettingsFirstStripeColorLabel.AutoSize = true;
            this.PreviewSettingsFirstStripeColorLabel.Location = new System.Drawing.Point(6, 212);
            this.PreviewSettingsFirstStripeColorLabel.Name = "PreviewSettingsFirstStripeColorLabel";
            this.PreviewSettingsFirstStripeColorLabel.Size = new System.Drawing.Size(141, 13);
            this.PreviewSettingsFirstStripeColorLabel.TabIndex = 12;
            this.PreviewSettingsFirstStripeColorLabel.Text = "First Background stripe color";
            // 
            // PreviewSettingsShowDescriptionCheckBox
            // 
            this.PreviewSettingsShowDescriptionCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewSettingsShowDescriptionCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviewSettingsShowDescriptionCheckBox.Location = new System.Drawing.Point(9, 177);
            this.PreviewSettingsShowDescriptionCheckBox.Name = "PreviewSettingsShowDescriptionCheckBox";
            this.PreviewSettingsShowDescriptionCheckBox.Size = new System.Drawing.Size(959, 24);
            this.PreviewSettingsShowDescriptionCheckBox.TabIndex = 11;
            this.PreviewSettingsShowDescriptionCheckBox.Text = "Show description";
            this.PreviewSettingsShowDescriptionCheckBox.UseVisualStyleBackColor = true;
            this.PreviewSettingsShowDescriptionCheckBox.CheckedChanged += new System.EventHandler(this.PreviewSettingsShowDescriptionCheckBox_CheckedChanged);
            // 
            // PreviewSettingsShowTitleCheckBox
            // 
            this.PreviewSettingsShowTitleCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewSettingsShowTitleCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviewSettingsShowTitleCheckBox.Location = new System.Drawing.Point(9, 157);
            this.PreviewSettingsShowTitleCheckBox.Name = "PreviewSettingsShowTitleCheckBox";
            this.PreviewSettingsShowTitleCheckBox.Size = new System.Drawing.Size(959, 24);
            this.PreviewSettingsShowTitleCheckBox.TabIndex = 10;
            this.PreviewSettingsShowTitleCheckBox.Text = "Show title";
            this.PreviewSettingsShowTitleCheckBox.UseVisualStyleBackColor = true;
            this.PreviewSettingsShowTitleCheckBox.CheckedChanged += new System.EventHandler(this.PreviewSettingsShowTitleCheckBox_CheckedChanged);
            // 
            // PreviewSettingsShowAvatarCheckBox
            // 
            this.PreviewSettingsShowAvatarCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewSettingsShowAvatarCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviewSettingsShowAvatarCheckBox.Location = new System.Drawing.Point(9, 136);
            this.PreviewSettingsShowAvatarCheckBox.Name = "PreviewSettingsShowAvatarCheckBox";
            this.PreviewSettingsShowAvatarCheckBox.Size = new System.Drawing.Size(959, 24);
            this.PreviewSettingsShowAvatarCheckBox.TabIndex = 9;
            this.PreviewSettingsShowAvatarCheckBox.Text = "Show avatar";
            this.PreviewSettingsShowAvatarCheckBox.UseVisualStyleBackColor = true;
            this.PreviewSettingsShowAvatarCheckBox.CheckedChanged += new System.EventHandler(this.PreviewSettingsShowAvatarCheckBox_CheckedChanged);
            // 
            // PreviewSettingsShowHeaderImageCheckBox
            // 
            this.PreviewSettingsShowHeaderImageCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewSettingsShowHeaderImageCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviewSettingsShowHeaderImageCheckBox.Location = new System.Drawing.Point(9, 117);
            this.PreviewSettingsShowHeaderImageCheckBox.Name = "PreviewSettingsShowHeaderImageCheckBox";
            this.PreviewSettingsShowHeaderImageCheckBox.Size = new System.Drawing.Size(959, 24);
            this.PreviewSettingsShowHeaderImageCheckBox.TabIndex = 8;
            this.PreviewSettingsShowHeaderImageCheckBox.Text = "Show header image";
            this.PreviewSettingsShowHeaderImageCheckBox.UseVisualStyleBackColor = true;
            this.PreviewSettingsShowHeaderImageCheckBox.CheckedChanged += new System.EventHandler(this.PreviewSettingsShowHeaderImageCheckBox_CheckedChanged);
            // 
            // PreviewSettingsBackgroundColorButton
            // 
            this.PreviewSettingsBackgroundColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewSettingsBackgroundColorButton.BackColor = System.Drawing.Color.Transparent;
            this.PreviewSettingsBackgroundColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviewSettingsBackgroundColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PreviewSettingsBackgroundColorButton.Location = new System.Drawing.Point(223, 88);
            this.PreviewSettingsBackgroundColorButton.Name = "PreviewSettingsBackgroundColorButton";
            this.PreviewSettingsBackgroundColorButton.Size = new System.Drawing.Size(745, 23);
            this.PreviewSettingsBackgroundColorButton.TabIndex = 7;
            this.PreviewSettingsBackgroundColorButton.Text = "Change color";
            this.PreviewSettingsBackgroundColorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PreviewSettingsBackgroundColorButton.UseVisualStyleBackColor = false;
            this.PreviewSettingsBackgroundColorButton.Click += new System.EventHandler(this.PreviewSettingsBackgroundColorButton_Click);
            // 
            // PreviewSettingsBackgroundColorLabel
            // 
            this.PreviewSettingsBackgroundColorLabel.AutoSize = true;
            this.PreviewSettingsBackgroundColorLabel.Location = new System.Drawing.Point(6, 93);
            this.PreviewSettingsBackgroundColorLabel.Name = "PreviewSettingsBackgroundColorLabel";
            this.PreviewSettingsBackgroundColorLabel.Size = new System.Drawing.Size(91, 13);
            this.PreviewSettingsBackgroundColorLabel.TabIndex = 6;
            this.PreviewSettingsBackgroundColorLabel.Text = "Background color";
            // 
            // PreviewSettingsAvatarShapeComboBox
            // 
            this.PreviewSettingsAvatarShapeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewSettingsAvatarShapeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PreviewSettingsAvatarShapeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviewSettingsAvatarShapeComboBox.FormattingEnabled = true;
            this.PreviewSettingsAvatarShapeComboBox.Location = new System.Drawing.Point(223, 61);
            this.PreviewSettingsAvatarShapeComboBox.Name = "PreviewSettingsAvatarShapeComboBox";
            this.PreviewSettingsAvatarShapeComboBox.Size = new System.Drawing.Size(745, 21);
            this.PreviewSettingsAvatarShapeComboBox.TabIndex = 5;
            this.PreviewSettingsAvatarShapeComboBox.SelectedIndexChanged += new System.EventHandler(this.PreviewSettingsAvatarShapeComboBox_SelectedIndexChanged);
            // 
            // PreviewSettingsAvatarShapeLabel
            // 
            this.PreviewSettingsAvatarShapeLabel.AutoSize = true;
            this.PreviewSettingsAvatarShapeLabel.Location = new System.Drawing.Point(6, 64);
            this.PreviewSettingsAvatarShapeLabel.Name = "PreviewSettingsAvatarShapeLabel";
            this.PreviewSettingsAvatarShapeLabel.Size = new System.Drawing.Size(70, 13);
            this.PreviewSettingsAvatarShapeLabel.TabIndex = 4;
            this.PreviewSettingsAvatarShapeLabel.Text = "Avatar shape";
            // 
            // PreviewSettingsDescriptionTextBox
            // 
            this.PreviewSettingsDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewSettingsDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreviewSettingsDescriptionTextBox.Location = new System.Drawing.Point(223, 34);
            this.PreviewSettingsDescriptionTextBox.Name = "PreviewSettingsDescriptionTextBox";
            this.PreviewSettingsDescriptionTextBox.Size = new System.Drawing.Size(745, 20);
            this.PreviewSettingsDescriptionTextBox.TabIndex = 3;
            this.PreviewSettingsDescriptionTextBox.TextChanged += new System.EventHandler(this.PreviewSettingsDescriptionTextBox_TextChanged);
            // 
            // PreviewSettingsDescriptionLabel
            // 
            this.PreviewSettingsDescriptionLabel.AutoSize = true;
            this.PreviewSettingsDescriptionLabel.Location = new System.Drawing.Point(6, 36);
            this.PreviewSettingsDescriptionLabel.Name = "PreviewSettingsDescriptionLabel";
            this.PreviewSettingsDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.PreviewSettingsDescriptionLabel.TabIndex = 2;
            this.PreviewSettingsDescriptionLabel.Text = "Description";
            // 
            // PreviewSettingsTitleTextBox
            // 
            this.PreviewSettingsTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewSettingsTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreviewSettingsTitleTextBox.Location = new System.Drawing.Point(223, 7);
            this.PreviewSettingsTitleTextBox.Name = "PreviewSettingsTitleTextBox";
            this.PreviewSettingsTitleTextBox.Size = new System.Drawing.Size(745, 20);
            this.PreviewSettingsTitleTextBox.TabIndex = 1;
            this.PreviewSettingsTitleTextBox.TextChanged += new System.EventHandler(this.PreviewSettingsTitleTextBox_TextChanged);
            // 
            // PreviewSettingsTitleLabel
            // 
            this.PreviewSettingsTitleLabel.AutoSize = true;
            this.PreviewSettingsTitleLabel.Location = new System.Drawing.Point(6, 10);
            this.PreviewSettingsTitleLabel.Name = "PreviewSettingsTitleLabel";
            this.PreviewSettingsTitleLabel.Size = new System.Drawing.Size(27, 13);
            this.PreviewSettingsTitleLabel.TabIndex = 0;
            this.PreviewSettingsTitleLabel.Text = "Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1007, 525);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.TabLayout);
            this.Controls.Add(this.MenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "Form1";
            this.Text = "Generate Quotes Code for Material Design on Tumblr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabLayout.ResumeLayout(false);
            this.PreviewTabPage.ResumeLayout(false);
            this.PreviewSettingsTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SaveAsProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GenerateCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitProgramToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ErrorLabel;
        private System.Windows.Forms.ToolStripStatusLabel NoteLabel;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        private System.Windows.Forms.TabPage TabPage2;
        private System.Windows.Forms.RichTextBox GeneratedCodeBox;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.Button MixQuotesButton;
        private System.Windows.Forms.Button DeleteSelectedQuoteButton;
        private System.Windows.Forms.Button ChangeSelectedQuoteButton;
        private System.Windows.Forms.Button AddQuoteButton;
        private System.Windows.Forms.Label SongLabel;
        private System.Windows.Forms.TextBox SongTextBox;
        private System.Windows.Forms.TextBox ArtistTextBox;
        private System.Windows.Forms.TextBox QuoteTextBox;
        private System.Windows.Forms.Label ArtistLabel;
        private System.Windows.Forms.Label QuoteLabel;
        private System.Windows.Forms.ListView QuotesList;
        private System.Windows.Forms.ColumnHeader ListViewHeaderQuote;
        private System.Windows.Forms.ColumnHeader ListViewHeaderArtist;
        private System.Windows.Forms.ColumnHeader ListViewHeaderSong;
        private System.Windows.Forms.TabControl TabLayout;
        private System.Windows.Forms.TabPage PreviewTabPage;
        private EO.WebBrowser.WinForm.WebControl PreviewWebControl;
        private EO.WebBrowser.WebView webView1;
        private System.Windows.Forms.ToolStripMenuItem PreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GeneratePreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenInExtBrowserToolStripMenuItem;
        private System.Windows.Forms.TabPage PreviewSettingsTabPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PreviewSettingsDescriptionLabel;
        private System.Windows.Forms.TextBox PreviewSettingsTitleTextBox;
        private System.Windows.Forms.Label PreviewSettingsTitleLabel;
        private System.Windows.Forms.TextBox PreviewSettingsDescriptionTextBox;
        private System.Windows.Forms.ComboBox PreviewSettingsAvatarShapeComboBox;
        private System.Windows.Forms.Label PreviewSettingsAvatarShapeLabel;
        private System.Windows.Forms.Button PreviewSettingsBackgroundColorButton;
        private System.Windows.Forms.Label PreviewSettingsBackgroundColorLabel;
        private System.Windows.Forms.ColorDialog PreviewSettingsColorDialog;
        private System.Windows.Forms.CheckBox PreviewSettingsShowHeaderImageCheckBox;
        private System.Windows.Forms.CheckBox PreviewSettingsShowAvatarCheckBox;
        private System.Windows.Forms.CheckBox PreviewSettingsShowTitleCheckBox;
        private System.Windows.Forms.CheckBox PreviewSettingsShowDescriptionCheckBox;
        private System.Windows.Forms.Button PreviewSettingsFirstStripeColoButton;
        private System.Windows.Forms.Label PreviewSettingsFirstStripeColorLabel;
        private System.Windows.Forms.Button PreviewSettingsSecondStripeColorButton;
        private System.Windows.Forms.Label PreviewSettingsSecondStripeColorLabel;
        private System.Windows.Forms.Button PreviewSettingsAvatarBorderColorButton;
        private System.Windows.Forms.Label PreviewSettingsAvatarBorderColorLabel;
        private System.Windows.Forms.ComboBox PreviewSettingsThemeColorComboBox;
        private System.Windows.Forms.Label PreviewSettingsThemeColorLabel;
        private System.Windows.Forms.CheckBox PreviewSettingsEndlessScrollingCheckBox;
        private System.Windows.Forms.CheckBox PreviewSettingsSlidingHeaderCheckBox;
        private System.Windows.Forms.CheckBox PreviewSettingsBackgroundStripesCheckBox;
        private System.Windows.Forms.CheckBox PreviewSettingsShowQuotesCheckBox;
    }
}


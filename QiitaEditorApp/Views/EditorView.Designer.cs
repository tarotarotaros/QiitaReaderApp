namespace QiitaEditorApp.Views
{
    partial class EditorView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorView));
            ArtcileTabControl = new MaterialSkin.Controls.MaterialTabControl();
            ARTICLE = new TabPage();
            DRAFT = new TabPage();
            WRITE = new TabPage();
            EditorTabImageList = new ImageList(components);
            panel1 = new Panel();
            ArtcileTabControl.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ArtcileTabControl
            // 
            ArtcileTabControl.Controls.Add(ARTICLE);
            ArtcileTabControl.Controls.Add(DRAFT);
            ArtcileTabControl.Controls.Add(WRITE);
            ArtcileTabControl.Depth = 0;
            ArtcileTabControl.ImageList = EditorTabImageList;
            ArtcileTabControl.Location = new Point(3, 0);
            ArtcileTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            ArtcileTabControl.Multiline = true;
            ArtcileTabControl.Name = "ArtcileTabControl";
            ArtcileTabControl.SelectedIndex = 0;
            ArtcileTabControl.Size = new Size(1041, 634);
            ArtcileTabControl.TabIndex = 6;
            // 
            // ARTICLE
            // 
            ARTICLE.ImageKey = "記事アイコン1.png";
            ARTICLE.Location = new Point(4, 39);
            ARTICLE.Name = "ARTICLE";
            ARTICLE.Padding = new Padding(3);
            ARTICLE.Size = new Size(1033, 591);
            ARTICLE.TabIndex = 0;
            ARTICLE.Text = "ARTICLE";
            ARTICLE.UseVisualStyleBackColor = true;
            // 
            // DRAFT
            // 
            DRAFT.ImageKey = "フロッピーディスクアイコン1.png";
            DRAFT.Location = new Point(4, 39);
            DRAFT.Name = "DRAFT";
            DRAFT.Padding = new Padding(3);
            DRAFT.Size = new Size(1033, 591);
            DRAFT.TabIndex = 1;
            DRAFT.Text = "DRAFT";
            DRAFT.UseVisualStyleBackColor = true;
            // 
            // WRITE
            // 
            WRITE.ImageKey = "鉛筆アイコン　4.png";
            WRITE.Location = new Point(4, 39);
            WRITE.Name = "WRITE";
            WRITE.Size = new Size(1033, 591);
            WRITE.TabIndex = 2;
            WRITE.Text = "WRITE";
            WRITE.UseVisualStyleBackColor = true;
            // 
            // EditorTabImageList
            // 
            EditorTabImageList.ColorDepth = ColorDepth.Depth32Bit;
            EditorTabImageList.ImageStream = (ImageListStreamer)resources.GetObject("EditorTabImageList.ImageStream");
            EditorTabImageList.TransparentColor = Color.Transparent;
            EditorTabImageList.Images.SetKeyName(0, "記事アイコン1.png");
            EditorTabImageList.Images.SetKeyName(1, "フロッピーディスクアイコン1.png");
            EditorTabImageList.Images.SetKeyName(2, "鉛筆アイコン　4.png");
            // 
            // panel1
            // 
            panel1.Controls.Add(ArtcileTabControl);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(1041, 567);
            panel1.TabIndex = 7;
            // 
            // EditorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 634);
            Controls.Add(panel1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = ArtcileTabControl;
            Name = "EditorView";
            StartPosition = FormStartPosition.CenterParent;
            ArtcileTabControl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl ArtcileTabControl;
        private TabPage ARTICLE;
        private TabPage DRAFT;
        private Panel panel1;
        private TabPage WRITE;
        private ImageList EditorTabImageList;
    }
}
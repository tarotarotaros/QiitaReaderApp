using System.Drawing;
using System.Windows.Forms;

namespace QiitaReaderApp.Views
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorView));
            this.ArtcileTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.ARTICLE = new System.Windows.Forms.TabPage();
            this.cardListPanel = new System.Windows.Forms.Panel();
            this.GRAPH = new System.Windows.Forms.TabPage();
            this.ArticleGraph = new QiitaReaderApp.Views.Controls.ArticleGraphControl();
            this.EditorTabImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ArtcileTabControl.SuspendLayout();
            this.ARTICLE.SuspendLayout();
            this.GRAPH.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArtcileTabControl
            // 
            this.ArtcileTabControl.Controls.Add(this.ARTICLE);
            this.ArtcileTabControl.Controls.Add(this.GRAPH);
            this.ArtcileTabControl.Depth = 0;
            this.ArtcileTabControl.ImageList = this.EditorTabImageList;
            this.ArtcileTabControl.Location = new System.Drawing.Point(3, 0);
            this.ArtcileTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ArtcileTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.ArtcileTabControl.Multiline = true;
            this.ArtcileTabControl.Name = "ArtcileTabControl";
            this.ArtcileTabControl.SelectedIndex = 0;
            this.ArtcileTabControl.Size = new System.Drawing.Size(892, 507);
            this.ArtcileTabControl.TabIndex = 6;
            // 
            // ARTICLE
            // 
            this.ARTICLE.Controls.Add(this.cardListPanel);
            this.ARTICLE.ImageKey = "記事アイコン1.png";
            this.ARTICLE.Location = new System.Drawing.Point(4, 39);
            this.ARTICLE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ARTICLE.Name = "ARTICLE";
            this.ARTICLE.Padding = new System.Windows.Forms.Padding(43, 40, 86, 80);
            this.ARTICLE.Size = new System.Drawing.Size(884, 464);
            this.ARTICLE.TabIndex = 0;
            this.ARTICLE.Text = "ARTICLE";
            this.ARTICLE.UseVisualStyleBackColor = true;
            // 
            // cardListPanel
            // 
            this.cardListPanel.AutoScroll = true;
            this.cardListPanel.BackColor = System.Drawing.Color.White;
            this.cardListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardListPanel.Location = new System.Drawing.Point(43, 40);
            this.cardListPanel.Margin = new System.Windows.Forms.Padding(0);
            this.cardListPanel.Name = "cardListPanel";
            this.cardListPanel.Size = new System.Drawing.Size(755, 344);
            this.cardListPanel.TabIndex = 1;
            // 
            // GRAPH
            // 
            this.GRAPH.Controls.Add(this.ArticleGraph);
            this.GRAPH.ImageKey = "折れ線と棒グラフのアイコン素材.png";
            this.GRAPH.Location = new System.Drawing.Point(4, 39);
            this.GRAPH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GRAPH.Name = "GRAPH";
            this.GRAPH.Padding = new System.Windows.Forms.Padding(20);
            this.GRAPH.Size = new System.Drawing.Size(884, 464);
            this.GRAPH.TabIndex = 1;
            this.GRAPH.Text = "GRAPH";
            this.GRAPH.UseVisualStyleBackColor = true;
            // 
            // ArticleGraph
            // 
            this.ArticleGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArticleGraph.Location = new System.Drawing.Point(20, 20);
            this.ArticleGraph.Name = "ArticleGraph";
            this.ArticleGraph.Size = new System.Drawing.Size(844, 424);
            this.ArticleGraph.TabIndex = 0;
            // 
            // EditorTabImageList
            // 
            this.EditorTabImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("EditorTabImageList.ImageStream")));
            this.EditorTabImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.EditorTabImageList.Images.SetKeyName(0, "折れ線と棒グラフのアイコン素材.png");
            this.EditorTabImageList.Images.SetKeyName(1, "記事アイコン1.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ArtcileTabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 454);
            this.panel1.TabIndex = 7;
            // 
            // EditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 507);
            this.Controls.Add(this.panel1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.ArtcileTabControl;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditorView";
            this.Padding = new System.Windows.Forms.Padding(3, 51, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ArtcileTabControl.ResumeLayout(false);
            this.ARTICLE.ResumeLayout(false);
            this.GRAPH.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl ArtcileTabControl;
        private TabPage ARTICLE;
        private TabPage GRAPH;
        private Panel panel1;
        private ImageList EditorTabImageList;
        private Panel cardListPanel;
        private Controls.ArticleGraphControl ArticleGraph;
    }
}
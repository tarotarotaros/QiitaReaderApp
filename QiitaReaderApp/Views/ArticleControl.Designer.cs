using System.Drawing;
using System.Windows.Forms;

namespace QiitaReaderApp.Views
{
    partial class ArticleControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticleControl));
            ArticleDetailCard = new MaterialSkin.Controls.MaterialCard();
            CounterPanel = new Panel();
            CommentCountLabel = new Label();
            FavoriteCountLabel = new Label();
            ViewPictureBox = new PictureBox();
            AccessCountLabel = new Label();
            CommentPictureBox = new PictureBox();
            StarPictureBox = new PictureBox();
            DateLabel = new Label();
            ArticleLinkButton = new MaterialSkin.Controls.MaterialButton();
            TitleLabel = new Label();
            ArticleDetailCard.SuspendLayout();
            CounterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CommentPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StarPictureBox).BeginInit();
            SuspendLayout();
            // 
            // ArticleDetailCard
            // 
            ArticleDetailCard.BackColor = Color.FromArgb(255, 255, 255);
            ArticleDetailCard.Controls.Add(CounterPanel);
            ArticleDetailCard.Controls.Add(DateLabel);
            ArticleDetailCard.Controls.Add(ArticleLinkButton);
            ArticleDetailCard.Controls.Add(TitleLabel);
            ArticleDetailCard.Depth = 0;
            ArticleDetailCard.Dock = DockStyle.Fill;
            ArticleDetailCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ArticleDetailCard.Location = new Point(2, 2);
            ArticleDetailCard.Margin = new Padding(14);
            ArticleDetailCard.MouseState = MaterialSkin.MouseState.HOVER;
            ArticleDetailCard.Name = "ArticleDetailCard";
            ArticleDetailCard.Padding = new Padding(14);
            ArticleDetailCard.Size = new Size(696, 126);
            ArticleDetailCard.TabIndex = 0;
            // 
            // CounterPanel
            // 
            CounterPanel.Controls.Add(CommentCountLabel);
            CounterPanel.Controls.Add(FavoriteCountLabel);
            CounterPanel.Controls.Add(ViewPictureBox);
            CounterPanel.Controls.Add(AccessCountLabel);
            CounterPanel.Controls.Add(CommentPictureBox);
            CounterPanel.Controls.Add(StarPictureBox);
            CounterPanel.Location = new Point(329, 38);
            CounterPanel.Name = "CounterPanel";
            CounterPanel.Size = new Size(256, 38);
            CounterPanel.TabIndex = 7;
            // 
            // CommentCountLabel
            // 
            CommentCountLabel.Font = new Font("BIZ UDゴシック", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CommentCountLabel.Location = new Point(223, 10);
            CommentCountLabel.Name = "CommentCountLabel";
            CommentCountLabel.Size = new Size(32, 19);
            CommentCountLabel.TabIndex = 8;
            CommentCountLabel.Text = "12";
            // 
            // FavoriteCountLabel
            // 
            FavoriteCountLabel.Font = new Font("BIZ UDゴシック", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FavoriteCountLabel.Location = new Point(133, 10);
            FavoriteCountLabel.Name = "FavoriteCountLabel";
            FavoriteCountLabel.Size = new Size(32, 19);
            FavoriteCountLabel.TabIndex = 7;
            FavoriteCountLabel.Text = "12";
            // 
            // ViewPictureBox
            // 
            ViewPictureBox.BackgroundImage = (Image)resources.GetObject("ViewPictureBox.BackgroundImage");
            ViewPictureBox.Location = new Point(3, 3);
            ViewPictureBox.Name = "ViewPictureBox";
            ViewPictureBox.Size = new Size(32, 32);
            ViewPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ViewPictureBox.TabIndex = 6;
            ViewPictureBox.TabStop = false;
            // 
            // AccessCountLabel
            // 
            AccessCountLabel.Font = new Font("BIZ UDゴシック", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AccessCountLabel.Location = new Point(43, 10);
            AccessCountLabel.Name = "AccessCountLabel";
            AccessCountLabel.Size = new Size(32, 19);
            AccessCountLabel.TabIndex = 3;
            AccessCountLabel.Text = "12";
            // 
            // CommentPictureBox
            // 
            CommentPictureBox.BackgroundImage = (Image)resources.GetObject("CommentPictureBox.BackgroundImage");
            CommentPictureBox.Location = new Point(183, 3);
            CommentPictureBox.Name = "CommentPictureBox";
            CommentPictureBox.Size = new Size(32, 32);
            CommentPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            CommentPictureBox.TabIndex = 5;
            CommentPictureBox.TabStop = false;
            // 
            // StarPictureBox
            // 
            StarPictureBox.BackgroundImage = (Image)resources.GetObject("StarPictureBox.BackgroundImage");
            StarPictureBox.Location = new Point(93, 3);
            StarPictureBox.Name = "StarPictureBox";
            StarPictureBox.Size = new Size(32, 32);
            StarPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            StarPictureBox.TabIndex = 4;
            StarPictureBox.TabStop = false;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("BIZ UDゴシック", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel.Location = new Point(17, 49);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(119, 19);
            DateLabel.TabIndex = 2;
            DateLabel.Text = "20YY/DD/MM ";
            // 
            // ArticleLinkButton
            // 
            ArticleLinkButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ArticleLinkButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ArticleLinkButton.Depth = 0;
            ArticleLinkButton.HighEmphasis = true;
            ArticleLinkButton.Icon = null;
            ArticleLinkButton.Image = (Image)resources.GetObject("ArticleLinkButton.Image");
            ArticleLinkButton.Location = new Point(614, 32);
            ArticleLinkButton.Margin = new Padding(4, 6, 4, 6);
            ArticleLinkButton.MouseState = MaterialSkin.MouseState.HOVER;
            ArticleLinkButton.Name = "ArticleLinkButton";
            ArticleLinkButton.NoAccentTextColor = Color.Empty;
            ArticleLinkButton.Size = new Size(64, 36);
            ArticleLinkButton.TabIndex = 1;
            ArticleLinkButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            ArticleLinkButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ArticleLinkButton.UseAccentColor = false;
            ArticleLinkButton.UseVisualStyleBackColor = true;
            ArticleLinkButton.Click += LinkButtonClicked;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("BIZ UDゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.Location = new Point(17, 14);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(178, 24);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "記事のタイトル";
            // 
            // ArticleControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(ArticleDetailCard);
            Name = "ArticleControl";
            Padding = new Padding(2);
            Size = new Size(700, 130);
            ArticleDetailCard.ResumeLayout(false);
            ArticleDetailCard.PerformLayout();
            CounterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ViewPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CommentPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)StarPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard ArticleDetailCard;
        private MaterialSkin.Controls.MaterialButton ArticleLinkButton;
        private Label TitleLabel;
        private Label DateLabel;
        private Label AccessCountLabel;
        private Panel CounterPanel;
        private PictureBox ViewPictureBox;
        private PictureBox CommentPictureBox;
        private PictureBox StarPictureBox;
        private Label CommentCountLabel;
        private Label FavoriteCountLabel;
    }
}

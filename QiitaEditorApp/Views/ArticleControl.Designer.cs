namespace QiitaEditorApp.Views
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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            dateLabel = new Label();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            titleLabel = new Label();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(dateLabel);
            materialCard1.Controls.Add(materialButton1);
            materialCard1.Controls.Add(titleLabel);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(2, 2);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(696, 146);
            materialCard1.TabIndex = 0;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("BIZ UDゴシック", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(17, 49);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(119, 19);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "20YY/DD/MM ";
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Image = (Image)resources.GetObject("materialButton1.Image");
            materialButton1.Location = new Point(614, 90);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(64, 36);
            materialButton1.TabIndex = 1;
            materialButton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += LinkButtonClicked;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("BIZ UDゴシック", 18F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(17, 14);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(178, 24);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "記事のタイトル";
            // 
            // ArticleControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(materialCard1);
            Name = "ArticleControl";
            Padding = new Padding(2);
            Size = new Size(700, 150);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Label titleLabel;
        private Label dateLabel;
    }
}

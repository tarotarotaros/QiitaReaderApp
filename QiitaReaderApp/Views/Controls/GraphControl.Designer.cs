namespace QiitaReaderApp.Views.Controls
{
    partial class ArticleGraphControl
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
            this.ArticleCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.SinceYearComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.SinceMonthComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.UntilMonthComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.UntilYearComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.SinceYearLabel = new System.Windows.Forms.Label();
            this.SinceMonthLabel = new System.Windows.Forms.Label();
            this.UntilMonthLabel = new System.Windows.Forms.Label();
            this.UntilYearLabel = new System.Windows.Forms.Label();
            this.BetweenLabel = new System.Windows.Forms.Label();
            this.ColumnDataComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.ColumnDataLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ArticleCartesianChart
            // 
            this.ArticleCartesianChart.Location = new System.Drawing.Point(13, 61);
            this.ArticleCartesianChart.Name = "ArticleCartesianChart";
            this.ArticleCartesianChart.Size = new System.Drawing.Size(644, 267);
            this.ArticleCartesianChart.TabIndex = 0;
            this.ArticleCartesianChart.Text = "cartesianChart1";
            // 
            // SinceYearComboBox
            // 
            this.SinceYearComboBox.AutoResize = false;
            this.SinceYearComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SinceYearComboBox.Depth = 0;
            this.SinceYearComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SinceYearComboBox.DropDownHeight = 174;
            this.SinceYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SinceYearComboBox.DropDownWidth = 121;
            this.SinceYearComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SinceYearComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SinceYearComboBox.FormattingEnabled = true;
            this.SinceYearComboBox.IntegralHeight = false;
            this.SinceYearComboBox.ItemHeight = 43;
            this.SinceYearComboBox.Location = new System.Drawing.Point(24, 4);
            this.SinceYearComboBox.MaxDropDownItems = 4;
            this.SinceYearComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.SinceYearComboBox.Name = "SinceYearComboBox";
            this.SinceYearComboBox.Size = new System.Drawing.Size(125, 49);
            this.SinceYearComboBox.StartIndex = 0;
            this.SinceYearComboBox.TabIndex = 1;
            this.SinceYearComboBox.SelectedIndexChanged += new System.EventHandler(this.SinceYearComboBox_SelectedIndexChanged);
            // 
            // SinceMonthComboBox
            // 
            this.SinceMonthComboBox.AutoResize = false;
            this.SinceMonthComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SinceMonthComboBox.Depth = 0;
            this.SinceMonthComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SinceMonthComboBox.DropDownHeight = 174;
            this.SinceMonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SinceMonthComboBox.DropDownWidth = 121;
            this.SinceMonthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SinceMonthComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SinceMonthComboBox.FormattingEnabled = true;
            this.SinceMonthComboBox.IntegralHeight = false;
            this.SinceMonthComboBox.ItemHeight = 43;
            this.SinceMonthComboBox.Location = new System.Drawing.Point(192, 4);
            this.SinceMonthComboBox.MaxDropDownItems = 4;
            this.SinceMonthComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.SinceMonthComboBox.Name = "SinceMonthComboBox";
            this.SinceMonthComboBox.Size = new System.Drawing.Size(86, 49);
            this.SinceMonthComboBox.StartIndex = 0;
            this.SinceMonthComboBox.TabIndex = 2;
            this.SinceMonthComboBox.SelectedIndexChanged += new System.EventHandler(this.SinceMonthComboBox_SelectedIndexChanged);
            // 
            // UntilMonthComboBox
            // 
            this.UntilMonthComboBox.AutoResize = false;
            this.UntilMonthComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UntilMonthComboBox.Depth = 0;
            this.UntilMonthComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.UntilMonthComboBox.DropDownHeight = 174;
            this.UntilMonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UntilMonthComboBox.DropDownWidth = 121;
            this.UntilMonthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.UntilMonthComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UntilMonthComboBox.FormattingEnabled = true;
            this.UntilMonthComboBox.IntegralHeight = false;
            this.UntilMonthComboBox.ItemHeight = 43;
            this.UntilMonthComboBox.Location = new System.Drawing.Point(534, 4);
            this.UntilMonthComboBox.MaxDropDownItems = 4;
            this.UntilMonthComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.UntilMonthComboBox.Name = "UntilMonthComboBox";
            this.UntilMonthComboBox.Size = new System.Drawing.Size(86, 49);
            this.UntilMonthComboBox.StartIndex = 0;
            this.UntilMonthComboBox.TabIndex = 4;
            this.UntilMonthComboBox.SelectedIndexChanged += new System.EventHandler(this.UntilMonthComboBox_SelectedIndexChanged);
            // 
            // UntilYearComboBox
            // 
            this.UntilYearComboBox.AutoResize = false;
            this.UntilYearComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UntilYearComboBox.Depth = 0;
            this.UntilYearComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.UntilYearComboBox.DropDownHeight = 174;
            this.UntilYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UntilYearComboBox.DropDownWidth = 121;
            this.UntilYearComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.UntilYearComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UntilYearComboBox.FormattingEnabled = true;
            this.UntilYearComboBox.IntegralHeight = false;
            this.UntilYearComboBox.ItemHeight = 43;
            this.UntilYearComboBox.Location = new System.Drawing.Point(366, 4);
            this.UntilYearComboBox.MaxDropDownItems = 4;
            this.UntilYearComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.UntilYearComboBox.Name = "UntilYearComboBox";
            this.UntilYearComboBox.Size = new System.Drawing.Size(125, 49);
            this.UntilYearComboBox.StartIndex = 0;
            this.UntilYearComboBox.TabIndex = 3;
            this.UntilYearComboBox.SelectedIndexChanged += new System.EventHandler(this.UntilYearComboBox_SelectedIndexChanged);
            // 
            // SinceYearLabel
            // 
            this.SinceYearLabel.AutoSize = true;
            this.SinceYearLabel.Font = new System.Drawing.Font("BIZ UDゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SinceYearLabel.Location = new System.Drawing.Point(155, 20);
            this.SinceYearLabel.Name = "SinceYearLabel";
            this.SinceYearLabel.Size = new System.Drawing.Size(31, 21);
            this.SinceYearLabel.TabIndex = 6;
            this.SinceYearLabel.Text = "年";
            // 
            // SinceMonthLabel
            // 
            this.SinceMonthLabel.AutoSize = true;
            this.SinceMonthLabel.Font = new System.Drawing.Font("BIZ UDゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SinceMonthLabel.Location = new System.Drawing.Point(284, 20);
            this.SinceMonthLabel.Name = "SinceMonthLabel";
            this.SinceMonthLabel.Size = new System.Drawing.Size(31, 21);
            this.SinceMonthLabel.TabIndex = 7;
            this.SinceMonthLabel.Text = "月";
            // 
            // UntilMonthLabel
            // 
            this.UntilMonthLabel.AutoSize = true;
            this.UntilMonthLabel.Font = new System.Drawing.Font("BIZ UDゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UntilMonthLabel.Location = new System.Drawing.Point(626, 20);
            this.UntilMonthLabel.Name = "UntilMonthLabel";
            this.UntilMonthLabel.Size = new System.Drawing.Size(31, 21);
            this.UntilMonthLabel.TabIndex = 9;
            this.UntilMonthLabel.Text = "月";
            // 
            // UntilYearLabel
            // 
            this.UntilYearLabel.AutoSize = true;
            this.UntilYearLabel.Font = new System.Drawing.Font("BIZ UDゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UntilYearLabel.Location = new System.Drawing.Point(497, 20);
            this.UntilYearLabel.Name = "UntilYearLabel";
            this.UntilYearLabel.Size = new System.Drawing.Size(31, 21);
            this.UntilYearLabel.TabIndex = 8;
            this.UntilYearLabel.Text = "年";
            // 
            // BetweenLabel
            // 
            this.BetweenLabel.AutoSize = true;
            this.BetweenLabel.Font = new System.Drawing.Font("BIZ UDゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BetweenLabel.Location = new System.Drawing.Point(321, 20);
            this.BetweenLabel.Name = "BetweenLabel";
            this.BetweenLabel.Size = new System.Drawing.Size(31, 21);
            this.BetweenLabel.TabIndex = 10;
            this.BetweenLabel.Text = "～";
            // 
            // ColumnDataComboBox
            // 
            this.ColumnDataComboBox.AutoResize = false;
            this.ColumnDataComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ColumnDataComboBox.Depth = 0;
            this.ColumnDataComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ColumnDataComboBox.DropDownHeight = 174;
            this.ColumnDataComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnDataComboBox.DropDownWidth = 121;
            this.ColumnDataComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ColumnDataComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColumnDataComboBox.FormattingEnabled = true;
            this.ColumnDataComboBox.IntegralHeight = false;
            this.ColumnDataComboBox.ItemHeight = 43;
            this.ColumnDataComboBox.Items.AddRange(new object[] {
            "投稿日",
            "月"});
            this.ColumnDataComboBox.Location = new System.Drawing.Point(334, 334);
            this.ColumnDataComboBox.MaxDropDownItems = 4;
            this.ColumnDataComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ColumnDataComboBox.Name = "ColumnDataComboBox";
            this.ColumnDataComboBox.Size = new System.Drawing.Size(125, 49);
            this.ColumnDataComboBox.StartIndex = 0;
            this.ColumnDataComboBox.TabIndex = 11;
            this.ColumnDataComboBox.SelectedIndexChanged += new System.EventHandler(this.ColumnDataComboBox_SelectedIndexChanged);
            // 
            // ColumnDataLabel
            // 
            this.ColumnDataLabel.AutoSize = true;
            this.ColumnDataLabel.Font = new System.Drawing.Font("BIZ UDゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ColumnDataLabel.Location = new System.Drawing.Point(213, 348);
            this.ColumnDataLabel.Name = "ColumnDataLabel";
            this.ColumnDataLabel.Size = new System.Drawing.Size(115, 21);
            this.ColumnDataLabel.TabIndex = 12;
            this.ColumnDataLabel.Text = "列データ：";
            // 
            // ArticleGraphControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ColumnDataLabel);
            this.Controls.Add(this.ColumnDataComboBox);
            this.Controls.Add(this.BetweenLabel);
            this.Controls.Add(this.UntilMonthLabel);
            this.Controls.Add(this.UntilYearLabel);
            this.Controls.Add(this.SinceMonthLabel);
            this.Controls.Add(this.SinceYearLabel);
            this.Controls.Add(this.UntilMonthComboBox);
            this.Controls.Add(this.UntilYearComboBox);
            this.Controls.Add(this.SinceMonthComboBox);
            this.Controls.Add(this.SinceYearComboBox);
            this.Controls.Add(this.ArticleCartesianChart);
            this.Name = "ArticleGraphControl";
            this.Size = new System.Drawing.Size(663, 389);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart ArticleCartesianChart;
        private MaterialSkin.Controls.MaterialComboBox SinceYearComboBox;
        private MaterialSkin.Controls.MaterialComboBox SinceMonthComboBox;
        private MaterialSkin.Controls.MaterialComboBox UntilMonthComboBox;
        private MaterialSkin.Controls.MaterialComboBox UntilYearComboBox;
        private System.Windows.Forms.Label SinceYearLabel;
        private System.Windows.Forms.Label SinceMonthLabel;
        private System.Windows.Forms.Label UntilMonthLabel;
        private System.Windows.Forms.Label UntilYearLabel;
        private System.Windows.Forms.Label BetweenLabel;
        private MaterialSkin.Controls.MaterialComboBox ColumnDataComboBox;
        private System.Windows.Forms.Label ColumnDataLabel;
    }
}

using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QiitaEditorApp.Views.Controls
{
    public partial class RoundedLabel : Label
    {
        private int borderRadius = 2;
        private float borderWidth = 1f;
        private string displayText = "";

        [Browsable(true)]
        [Category("Appearance")]
        [Description("半径の値")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate(); // プロパティが変更されたら再描画
            }
        }


        [Browsable(true)]
        [Category("Appearance")]
        [Description("The width of the border.")]
        public float BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                this.Invalidate(); // プロパティが変更されたら再描画
            }
        }


        [Browsable(true)]
        [Category("Appearance")]
        [Description("表示文字列")]
        public string DisplayText
        {
            get { return displayText; }
            set
            {
                displayText = value;
                this.Invalidate(); // プロパティが変更されたら再描画
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.Text = string.Empty;

            base.OnPaint(e);

            // ラベルの領域を取得し、枠線の太さを考慮して調整
            RectangleF rect = new RectangleF(borderWidth / 2, borderWidth / 2, this.Width - borderWidth, this.Height - borderWidth);

            // グラフィックスの品質を高める設定
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // 丸角のグラフィックスパスを作成
            using (GraphicsPath path = GetRoundedRectanglePath(rect, BorderRadius))
            {
                // 背景を描画
                e.Graphics.FillPath(new SolidBrush(this.BackColor), path);

                // 枠線を描画
                using (Pen pen = new Pen(this.ForeColor, borderWidth))
                {
                    e.Graphics.DrawPath(pen, path);
                }

                // テキストのサイズを計算
                Size textSize = TextRenderer.MeasureText(this.displayText, this.Font);

                // テキストの中央位置を計算
                Point textLocation = new Point(
                    (int)((this.Width - textSize.Width) / 2),
                    (int)((this.Height - textSize.Height) / 2)
                );

                // テキストを描画
                TextRenderer.DrawText(e.Graphics, this.displayText, this.Font, textLocation, this.ForeColor);
            }
        }

        private GraphicsPath GetRoundedRectanglePath(RectangleF rect, int radius)
        {
            float diameter = radius * 2;
            SizeF size = new SizeF(diameter, diameter);
            RectangleF arc = new RectangleF(rect.Location, size);
            GraphicsPath path = new GraphicsPath();

            // 上左
            path.AddArc(arc, 180, 90);

            // 上右
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // 下右
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // 下左
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}

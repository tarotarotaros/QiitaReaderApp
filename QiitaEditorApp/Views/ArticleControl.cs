using QiitaEditorApp.Views.Controls;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;

namespace QiitaEditorApp.Views
{
    public partial class ArticleControl : UserControl
    {
        private List<string> _labelNameList = new List<string>();

        [Browsable(true)]
        [Category("Appearance")]
        [Description("タイトル")]
        public string Title
        {
            get { return this.titleLabel.Text; }
            set
            {
                this.titleLabel.Text = value;
                this.Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("作成日")]
        public DateTime? CreateDate
        {
            get {
                if (string.IsNullOrEmpty(this.dateLabel.Text)) return DateTime.MinValue;
                return DateTime.Parse(this.dateLabel.Text); }
            set
            {
                if (!value.HasValue)
                {
                    this.dateLabel.Text = string.Empty;
                }
                this.dateLabel.Text = value.Value.ToString("yyyy/MM/dd");
                this.Invalidate();
            }
        }

        private Collection<string> _tags = new Collection<string>();
        [Browsable(true)]
        [Category("Appearance")]
        [Description("タグ")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Collection<string> Tags
        {
            get { return _tags; }
            set
            {
                this._tags = value;
                ClearTags();
                value.ToList().ForEach(tag => AddTag(tag));
                this.Invalidate();
            }
        }

        private string _url = "";
        [Browsable(true)]
        [Category("Appearance")]
        [Description("URL")]
        public string Url
        {
            get { return _url; }
            set
            {
                _url = value;
                this.Invalidate();
            }
        }

        public ArticleControl()
        {
            InitializeComponent();

            this.dateLabel.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void AddTag(string tag)
        {
            _labelNameList.Add(tag);
            RoundedLabel label = new RoundedLabel();
            label.Text = tag;
            label.Size = new Size(100, 30);
            label.Location = new Point(20 + (_labelNameList.Count - 1) * (100+20), 80);
            label.DisplayText = tag;
            label.BorderRadius = 14;
            label.BorderWidth = 2f;

            this.materialCard1.Controls.Add(label);
        }

        private void ClearTags()
        {
            _labelNameList.ForEach(name =>
            {
                var label = this.materialCard1.Controls.Find(name, true).FirstOrDefault();
                if (label != null)
                {
                    this.Controls.Remove(label);
                    label.Dispose();
                }
            });
        }

        private void LinkButtonClicked(object sender, EventArgs e)
        {
            OpenUrl(_url);
        }

        private Process OpenUrl(string url)
        {
            ProcessStartInfo pi = new ProcessStartInfo()
            {
                FileName = url,
                UseShellExecute = true,
            };

            return Process.Start(pi);
        }
    }
}

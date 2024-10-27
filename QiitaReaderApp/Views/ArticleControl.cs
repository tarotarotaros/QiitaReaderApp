using QiitaReaderApp.Views.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QiitaReaderApp.Views
{
    public partial class ArticleControl : UserControl
    {
        private List<string> _labelNameList = new List<string>();
        private Collection<string> _tags = new Collection<string>();

        [Browsable(true)]
        [Category("Appearance")]
        [Description("タイトル")]
        public string Title
        {
            get { return this.TitleLabel.Text; }
            set
            {
                this.TitleLabel.Text = value;
                this.Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("作成日")]
        public DateTime? CreateDate
        {
            get {
                if (string.IsNullOrEmpty(this.DateLabel.Text)) return DateTime.MinValue;
                return DateTime.Parse(this.DateLabel.Text); }
            set
            {
                if (!value.HasValue)
                {
                    this.DateLabel.Text = string.Empty;
                }
                this.DateLabel.Text = value.Value.ToString("yyyy/MM/dd");
                this.Invalidate();
            }
        }

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

        [Browsable(true)]
        [Category("Appearance")]
        [Description("閲覧者数")]
        public int ViewCount
        {
            get { return int.Parse(this.AccessCountLabel.Text); }
            set
            {
                this.AccessCountLabel.Text = value.ToString();
                this.Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("いいね数")]
        public int FavoriteCount
        {
            get { return int.Parse(this.FavoriteCountLabel.Text); }
            set
            {
                this.FavoriteCountLabel.Text = value.ToString();
                this.Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("コメント数")]
        public int CommentCount
        {
            get { return int.Parse(this.CommentCountLabel.Text); }
            set
            {
                this.CommentCountLabel.Text = value.ToString();
                this.Invalidate();
            }
        }

        public ArticleControl()
        {
            InitializeComponent();

            this.DateLabel.Text = DateTime.Now.ToString("yyyy/MM/dd");
            this.ViewCount = 0;
            this.FavoriteCount = 0;
            this.CommentCount = 0;
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

            this.ArticleDetailCard.Controls.Add(label);
        }

        private void ClearTags()
        {
            _labelNameList.ForEach(name =>
            {
                var label = this.ArticleDetailCard.Controls.Find(name, true).FirstOrDefault();
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

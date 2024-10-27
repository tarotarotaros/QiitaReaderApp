using LiveCharts;
using LiveCharts.Wpf;
using QiitaEditorApp.Models;
using QiitaEditorApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QiitaEditorApp.Views.Controls
{
    public partial class ArticleGraphControl : UserControl
    {
        private bool _isLoadingFlag = false;
        private List<Article> _articles = new List<Article>();

        public void SetArticles(List<Article> articles)
        {
            _articles = articles;
            InitilizedSelectControl(articles);

            this.ArticleCartesianChart.AxisY.Add(new Axis
            {
                Title = "数",
                LabelFormatter = value => value.ToString()
            });
            UpdateGraph();
        }

        public ArticleGraphControl()
        {
            InitializeComponent();
        }

        private void InitilizedSelectControl(List<Article> articles)
        {
            _isLoadingFlag = true;
            var resultMinMax = GetMinMaxYearMonth(articles.Select(article => article.Date).ToList());
            this.SinceMonthComboBox.Items.AddRange(Enumerable.Range(1, 12).Select(i => i.ToString()).ToArray());
            this.SinceYearComboBox.Items.AddRange(Enumerable.Range(resultMinMax.Item1.Item1, resultMinMax.Item2.Item1 - resultMinMax.Item1.Item1 + 1).Select(i => i.ToString()).ToArray());
            this.UntilMonthComboBox.Items.AddRange(Enumerable.Range(1, 12).Select(i => i.ToString()).ToArray());
            this.UntilYearComboBox.Items.AddRange(Enumerable.Range(resultMinMax.Item1.Item1, resultMinMax.Item2.Item1 - resultMinMax.Item1.Item1 + 1).Select(i => i.ToString()).ToArray());

            this.SinceMonthComboBox.SelectedIndex = 0;
            this.SinceYearComboBox.SelectedIndex = 0;
            this.UntilMonthComboBox.SelectedIndex = this.UntilMonthComboBox.Items.Count - 1;
            this.UntilYearComboBox.SelectedIndex = this.UntilYearComboBox.Items.Count - 1;

            this.ColumnDataComboBox.Items.Clear();
            this.ColumnDataComboBox.Items.AddRange(Enum.GetValues(typeof(XAxisType)).Cast<XAxisType>().Select(x => x.ToString()).ToArray());
            this.ColumnDataComboBox.SelectedIndex = 0;

            this.ArticleCartesianChart.LegendLocation = LegendLocation.Right;
            this.ArticleCartesianChart.DataClick += CartesianChart1OnDataClick;
            _isLoadingFlag = false;
        }


        private void UpdateGraph()
        {
            if (_isLoadingFlag)
            {
                return;
            }

            var alalyzer = new ArticleAnalyzer(_articles);

            var sinceYear = int.Parse(this.SinceYearComboBox.SelectedItem.ToString());
            var sinceMonth = int.Parse(this.SinceMonthComboBox.SelectedItem.ToString());
            var untilYear = int.Parse(this.UntilYearComboBox.SelectedItem.ToString());
            var untilMonth = int.Parse(this.UntilMonthComboBox.SelectedItem.ToString());
            var xAxisType = (XAxisType)this.ColumnDataComboBox.SelectedIndex;

            this.ArticleCartesianChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "いいね",
                    Values = new ChartValues<int>(alalyzer.GetFavoriteCounts(sinceYear,sinceMonth,untilYear,untilMonth, xAxisType)),
                    LineSmoothness = 0,
                },
                new LineSeries
                {
                    Title = "閲覧者",
                    Values = new ChartValues<int>(alalyzer.GetViewCounts(sinceYear,sinceMonth,untilYear,untilMonth,xAxisType)),
                    LineSmoothness = 0,
                },
                new LineSeries
                {
                    Title = "コメント",
                    Values = new ChartValues<int>(alalyzer.GetCommentCounts(sinceYear,sinceMonth,untilYear,untilMonth,xAxisType)),
                    LineSmoothness = 0,
                }
            };

            this.ArticleCartesianChart.AxisX.Clear();
            this.ArticleCartesianChart.AxisX.Add(new Axis
            {
                Title = "投稿日",
                Labels = alalyzer.GetXAxisData(sinceYear, sinceMonth, untilYear, untilMonth, xAxisType),
            });

        }


        private void CartesianChart1OnDataClick(object sender, ChartPoint chartPoint)
        {
            MessageBox.Show("You clicked (" + chartPoint.X + "," + chartPoint.Y + ")");
        }


        private (Tuple<int, int>, Tuple<int, int>) GetMinMaxYearMonth(List<DateTime> dates)
        {
            if (dates == null || dates.Count == 0)
            {
                throw new ArgumentException("The list of dates cannot be null or empty.");
            }

            // 最小と最大の日時を取得
            var minDate = dates.Min();
            var maxDate = dates.Max();

            // (年, 月) のタプルを返す
            return (Tuple.Create(minDate.Year, minDate.Month), Tuple.Create(maxDate.Year, maxDate.Month));
        }

        private void SinceYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGraph();
        }

        private void SinceMonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGraph();
        }

        private void UntilYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGraph();
        }

        private void UntilMonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGraph();
        }

        private void ColumnDataComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGraph();
        }
    }
}

using QiitaReaderApp.Services.Dummy;
using QiitaReaderApp.Views.Controls;
using System.Windows.Forms;

namespace QiitaReaderAppTest.UI
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

            DummyArticleDataService dummyArticleDataService = new DummyArticleDataService();
            var articles = dummyArticleDataService.GetList();
            ArticleGraphControl articleGraphControl = new ArticleGraphControl();
            articleGraphControl.SetArticles(articles.Result);
            this.Controls.Add(articleGraphControl);
        }
    }
}

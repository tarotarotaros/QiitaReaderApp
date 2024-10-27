using QiitaEditorApp.Services.Dummy;
using QiitaEditorApp.Views.Controls;
using System.Windows.Forms;

namespace QiitaEditorAppTest.UI
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

            DummyArticleDataService dummyArticleDataService = new DummyArticleDataService();
            var articles = dummyArticleDataService.GetList();
            ArticleGraphControl articleGraphControl = new ArticleGraphControl(articles.Result);
            this.Controls.Add(articleGraphControl);
        }
    }
}

using QiitaReaderApp.Services.Dummy;
using QiitaReaderApp.Views;
using System.Linq;

namespace QiitaReaderApp.Presenters
{
    public class EditorPresenter
    {
        private readonly IEditorView _editorView;

        public EditorPresenter(IEditorView editorView)
        {
            _editorView = editorView;

            var service = new DummyArticleDataService();
            var articleList = service.GetList();
            articleList.Result.ToList().ForEach(article =>
            {
                _editorView.AddCard(article.Title, article.Date, article.Tags, article.Url, article.ViewCount, article.FavoriteCount, article.CommentCount);
            });

            _editorView.SetArticles(articleList.Result.ToList());
        }


    }
}

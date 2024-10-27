using QiitaEditorApp.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace QiitaEditorAppTest.Services
{
    public class ArticleDataServiceTest
    {
        [Fact]
        public async Task データ取得確認()
        {
            // Arrange
            var articleDataService = new ArticleDataService();

            // Act
            var result = await articleDataService.GetList();

            result.ForEach(article =>
            {
                Console.WriteLine(article.Title);
            });
        }

    }
}

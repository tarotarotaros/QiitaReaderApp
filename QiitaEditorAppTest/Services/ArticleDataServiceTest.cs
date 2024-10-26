using QiitaEditorApp.Services;
using System;
using Xunit;

namespace QiitaEditorAppTest.Services
{
    public class ArticleDataServiceTest
    {
        [Fact]
        public async void MyTestMethod()
        {
            // Arrange
            var articleDataService = new ArticleDataService();

            // Act
            var result = await articleDataService.GetList();

            result.ForEach(article =>
            {
                Console.WriteLine(article.Title);
            });
            // Assert
            // ここで何を検証するかを考える
        }

    }
}

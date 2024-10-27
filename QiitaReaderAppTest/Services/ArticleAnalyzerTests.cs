using QiitaReaderApp.Models;
using QiitaReaderApp.Services;
using System;
using System.Collections.Generic;
using Xunit;


namespace QiitaReaderAppTest.Services
{
    public class ArticleAnalyzerTests
    {
        // テストデータを作成
        private List<Article> GetTestArticles()
        {
            return new List<Article>
        {
            new Article { Title = "Article 1", Date = new DateTime(2024, 1, 1), ViewCount = 100, FavoriteCount = 10, CommentCount = 5 },
            new Article { Title = "Article 2", Date = new DateTime(2024, 1, 1), ViewCount = 50, FavoriteCount = 5, CommentCount = 3 },
            new Article { Title = "Article 3", Date = new DateTime(2024, 2, 1), ViewCount = 200, FavoriteCount = 20, CommentCount = 10 },
            new Article { Title = "Article 4", Date = new DateTime(2024, 2, 15), ViewCount = 250, FavoriteCount = 25, CommentCount = 12 },
            new Article { Title = "Article 5", Date = new DateTime(2024, 3, 5), ViewCount = 300, FavoriteCount = 30, CommentCount = 15 },
            new Article { Title = "Article 6", Date = new DateTime(2024, 3, 5), ViewCount = 100, FavoriteCount = 10, CommentCount = 5 }
        };
        }

        [Theory]
        [InlineData(XAxisType.Single, new[] { 10, 5, 20, 25, 30, 10 })]
        [InlineData(XAxisType.Day, new[] { 15, 20, 25, 40 })]
        [InlineData(XAxisType.Month, new[] { 15, 45, 40 })]
        public void TestGetFavoriteCounts(XAxisType xAxisType, int[] expected)
        {
            var articles = GetTestArticles();
            var analyzer = new ArticleAnalyzer(articles);
            var result = analyzer.GetFavoriteCounts(2024, 1, 2024, 3, xAxisType);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(XAxisType.Single, new[] { 100, 50, 200, 250, 300, 100 })]
        [InlineData(XAxisType.Day, new[] { 150, 200, 250, 400 })]
        [InlineData(XAxisType.Month, new[] { 150, 450, 400 })]
        public void TestGetViewCounts(XAxisType xAxisType, int[] expected)
        {
            var articles = GetTestArticles();
            var analyzer = new ArticleAnalyzer(articles);
            var result = analyzer.GetViewCounts(2024, 1, 2024, 3, xAxisType);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(XAxisType.Single, new[] { 5, 3, 10, 12, 15, 5 })]
        [InlineData(XAxisType.Day, new[] { 8, 10, 12, 20 })]
        [InlineData(XAxisType.Month, new[] { 8, 22, 20 })]
        public void TestGetCommentCounts(XAxisType xAxisType, int[] expected)
        {
            var articles = GetTestArticles();
            var analyzer = new ArticleAnalyzer(articles);
            var result = analyzer.GetCommentCounts(2024, 1, 2024, 3, xAxisType);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(XAxisType.Single, new[] { "Article 1", "Article 2", "Article 3", "Article 4", "Article 5", "Article 6" })]
        [InlineData(XAxisType.Day, new[] { "2024-01-01", "2024-02-01", "2024-02-15", "2024-03-05" })]
        [InlineData(XAxisType.Month, new[] { "2024-1", "2024-2", "2024-3" })]
        public void TestGetXAxisData(XAxisType xAxisType, string[] expected)
        {
            var articles = GetTestArticles();
            var analyzer = new ArticleAnalyzer(articles);
            var result = analyzer.GetXAxisData(2024, 1, 2024, 3, xAxisType);

            Assert.Equal(expected, result);
        }
    }


}

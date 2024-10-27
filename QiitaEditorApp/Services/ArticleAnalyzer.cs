using QiitaEditorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QiitaEditorApp.Services
{
    public enum XAxisType
    {
        Single = 0,
        Day = 1,
        Month = 2,
    }

    public class ArticleAnalyzer
    {
        private List<Article> articles;

        public ArticleAnalyzer(List<Article> articles)
        {
            this.articles = articles;
        }

        // いいね数のint配列の取得
        public int[] GetFavoriteCounts(int startYear, int startMonth, int endYear, int endMonth, XAxisType xAxisType)
        {
            return GetCounts(startYear, startMonth, endYear, endMonth, xAxisType, article => article.FavoriteCount);
        }

        // 閲覧者数のint配列の取得
        public int[] GetViewCounts(int startYear, int startMonth, int endYear, int endMonth, XAxisType xAxisType)
        {
            return GetCounts(startYear, startMonth, endYear, endMonth, xAxisType, article => article.ViewCount);
        }

        // コメント数のint配列の取得
        public int[] GetCommentCounts(int startYear, int startMonth, int endYear, int endMonth, XAxisType xAxisType)
        {
            return GetCounts(startYear, startMonth, endYear, endMonth, xAxisType, article => article.CommentCount);
        }

        // X軸データリストの取得
        public List<string> GetXAxisData(int startYear, int startMonth, int endYear, int endMonth, XAxisType xAxisType)
        {
            DateTime startDate = new DateTime(startYear, startMonth, 1);
            DateTime endDate = new DateTime(endYear, endMonth, DateTime.DaysInMonth(endYear, endMonth));

            var filteredArticles = articles.Where(article => article.Date >= startDate && article.Date <= endDate);

            switch (xAxisType)
            {
                case XAxisType.Single:
                    return filteredArticles.Select(article => article.Title).ToList();
                case XAxisType.Day:
                    return filteredArticles.GroupBy(article => article.Date.Date)
                                            .Select(group => group.Key.ToString("yyyy-MM-dd"))
                                            .ToList();
                case XAxisType.Month:
                    return filteredArticles.GroupBy(article => new { article.Date.Year, article.Date.Month })
                                            .Select(group => $"{group.Key.Year}-{group.Key.Month}")
                                            .ToList();
                default:
                    throw new ArgumentException("無効なX軸データのタイプです");
            }
        }

        // 共通のカウント取得ロジック
        private int[] GetCounts(int startYear, int startMonth, int endYear, int endMonth, XAxisType xAxisType, Func<Article, int> selector)
        {
            DateTime startDate = new DateTime(startYear, startMonth, 1);
            DateTime endDate = new DateTime(endYear, endMonth, DateTime.DaysInMonth(endYear, endMonth));

            var filteredArticles = articles.Where(article => article.Date >= startDate && article.Date <= endDate);

            switch (xAxisType)
            {
                case XAxisType.Single:
                    return filteredArticles.Select(selector).ToArray();
                case XAxisType.Day:
                    return filteredArticles.GroupBy(article => article.Date.Date)
                                            .Select(group => group.Sum(selector))
                                            .ToArray();
                case XAxisType.Month:
                    return filteredArticles.GroupBy(article => new { article.Date.Year, article.Date.Month })
                                            .Select(group => group.Sum(selector))
                                            .ToArray();
                default:
                    throw new ArgumentException("無効なX軸データのタイプです");
            }
        }
    }

}

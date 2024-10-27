using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace QiitaReaderApp.Models
{
    public class ResArticleConverter
    {
        public ResArticleConverter()
        {
                
        }

        public List<Article> Convert(string jsonResponse)
        {
            var articles = JsonConvert.DeserializeObject<List<Article>>(jsonResponse, new JsonSerializerSettings
            {
                MissingMemberHandling = MissingMemberHandling.Ignore,
                Error = (sender, args) =>
                {
                    args.ErrorContext.Handled = true;
                }
            });

            var jsonArray = JArray.Parse(jsonResponse);
            var parsedArticles = new List<Article>();
            foreach (var item in jsonArray)
            {
                var article = new Article
                {
                    Title = item["title"].ToString(),
                    Content = item["body"].ToString(),
                    Date = DateTime.Parse(item["created_at"].ToString()),
                    Url = item["url"].ToString(),
                    Tags = new List<string>()
                };

                // タグの処理
                foreach (var tag in item["tags"])
                {
                    article.Tags.Add(tag["name"].ToString());
                }

                parsedArticles.Add(article);
            }

            return parsedArticles;
        }
    }
}

using System;
using System.Collections.Generic;

namespace QiitaReaderApp.Models
{
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public List<string> Tags { get; set; }
        public string Tag { get; set; }
        public string Url { get; set; }
        public int ViewCount { get; set; }
        public int FavoriteCount { get; set; }
        public int CommentCount { get; set; }
    }
}

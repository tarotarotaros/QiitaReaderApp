using QiitaEditorApp.Models;
using QiitaEditorApp.Services.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QiitaEditorApp.Services.Dummy
{
    public class DummyArticleDataService : IArticleDataService
    {
        public async Task<List<Article>> GetList()
        {
            var list = new List<Article>() {
                new Article { Title = "タイトル1", Date = new DateTime(2024, 1, 1), Tags = new List<string>(){"タグ1", "タグ2" }, Url = "https://www.example.com", Content="1", CommentCount= 11, ViewCount = 35 , FavoriteCount = 33 },
                new Article { Title = "タイトル2", Date = new DateTime(2024, 2, 15),Tags = new List<string>(){"タグ1", "タグ2" }, Url = "https://www.google.com", Content="2", CommentCount= 33, ViewCount = 66 , FavoriteCount = 53 },
                new Article { Title = "タイトル3", Date = new DateTime(2024, 3, 30),Tags = new List<string>(){"タグ1", "タグ2" }, Url = "https://www.microsoft.com", Content="3", CommentCount= 12, ViewCount = 220 , FavoriteCount = 85 },
                new Article { Title = "タイトル4", Date = new DateTime(2024, 3, 30),Tags = new List<string>(){"タグ1", "タグ2" }, Url = "https://www.microsoft.com", Content="4", CommentCount= 4, ViewCount = 12 , FavoriteCount = 8 },
                new Article { Title = "タイトル5", Date = new DateTime(2024, 4, 30),Tags = new List<string>(){"タグ1", "タグ2" }, Url = "https://www.microsoft.com", Content="5", CommentCount= 1, ViewCount = 3 , FavoriteCount = 2 },
                new Article { Title = "タイトル6", Date = new DateTime(2024, 5, 30),Tags = new List<string>(){"タグ1", "タグ2" }, Url = "https://www.microsoft.com", Content="6", CommentCount= 0, ViewCount = 0 , FavoriteCount = 0 },
                new Article { Title = "タイトル7", Date = new DateTime(2024, 6, 30),Tags = new List<string>(){"タグ1", "タグ2" }, Url = "https://www.microsoft.com", Content="7", CommentCount= 0, ViewCount = 10 , FavoriteCount = 1 },
                new Article { Title = "タイトル8", Date = new DateTime(2024, 7, 30),Tags = new List<string>(){"タグ1", "タグ2" }, Url = "https://www.microsoft.com", Content="8", CommentCount= 0, ViewCount = 30 , FavoriteCount = 3 },
                new Article { Title = "タイトル9", Date = new DateTime(2024, 8, 30),Tags = new List<string>(){"タグ1", "タグ2" }, Url = "https://www.microsoft.com", Content="9", CommentCount= 0, ViewCount = 50 , FavoriteCount = 5 },
            };
            return list;
            
        }

        public void LoadSetting()
        {
            //nop
        }
    }
}

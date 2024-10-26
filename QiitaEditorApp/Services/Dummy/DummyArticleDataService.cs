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
                new Article { Title = "タイトル1", Date = new DateTime(2024, 1, 1), Tag = "タグ1", Url = "https://www.example.com", Content="1" },
                new Article { Title = "タイトル2", Date = new DateTime(2024, 2, 15), Tag = "タグ2", Url = "https://www.google.com", Content="2" },
                new Article { Title = "タイトル3", Date = new DateTime(2024, 3, 30), Tag = "タグ3", Url = "https://www.microsoft.com", Content="3" }
            };
            return list;
            
        }

        public void LoadSetting()
        {
            //nop
        }
    }
}

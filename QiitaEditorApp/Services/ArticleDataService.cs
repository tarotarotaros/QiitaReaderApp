using QiitaEditorApp.Models;
using QiitaEditorApp.Services.Interface;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace QiitaEditorApp.Services
{

    public class ArticleDataService : IArticleDataService
    {
        private const string API_BASE_URL = "https://qiita.com/api/v2/items";
        private string _userName;
        private string _qiitaAccessToken;

        public ArticleDataService()
        {
            LoadSetting();
        }

        public void LoadSetting()
        {
            var settingService = new SettingFileService();

            _userName = settingService.ReadUserName();
            _qiitaAccessToken = settingService.ReadApiToken();
        }

        public async Task<List<Article>> GetList() {
            var query = "user:" + _userName;  // 検索クエリ
            var requestUrl = $"{API_BASE_URL}?query={Uri.EscapeDataString(query)}";

            using (var httpClient = new HttpClient())
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_qiitaAccessToken}");
                    var response = await httpClient.GetAsync(requestUrl);

                    // 成功したかチェック
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        var resArticleConverter = new ResArticleConverter();
                        var result = resArticleConverter.Convert(jsonResponse);

                        return result;
                    }
                    else
                    {
                        throw new Exception($"StatusCode: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"{ex.Message}");
                }
            }
        }
    }
}

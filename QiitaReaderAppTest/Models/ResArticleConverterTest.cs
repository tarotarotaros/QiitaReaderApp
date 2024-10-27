using QiitaReaderApp.Models;
using Xunit;

namespace QiitaReaderAppTest.Models
{
    public class ResArticleConverterTest
    {
        [Fact]
        public void Convert_変換処理()
        {
            string jsonResponse = @"[
            {
                'title': 'タイトル',
                'body': '作成しました。',
                'created_at': '2024-10-17T21:09:24',
                'url': 'https://qiita.com/tarotarotaros/items/fe16ad944fe44335e156',
                'tags': [
                    { 'name': 'TypeScript' },
                    { 'name': 'Laravel' },
                    { 'name': 'ポートフォリオ' },
                    { 'name': 'React' }
                ]
            }
            ]";

            var resArticleConverter = new ResArticleConverter();
            var result = resArticleConverter.Convert(jsonResponse);

            Assert.Single(result);
            Assert.Equal("タイトル", result[0].Title);
            Assert.Equal("作成しました。", result[0].Content);
            Assert.Equal("2024/10/17 21:09:24", result[0].Date.ToString());
            Assert.Equal("ポートフォリオ", result[0].Tags[2]);
        }
    }
}

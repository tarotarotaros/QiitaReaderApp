using QiitaEditorApp.Services;
using System;
using System.IO;
using Xunit;

namespace QiitaEditorAppTest.Services
{
    public class SettintgFileServiceTests : IDisposable
    {
        private readonly SettingFileService _service;

        public SettintgFileServiceTests()
        {
            _service = new SettingFileService();
        }

        public void Dispose()
        {

            var fullPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "setting.json");

            // テスト終了後にテスト用のINIファイルを削除
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
        }

        [Fact]
        public void WriteUserName_ShouldSaveUserNameToIniFile()
        {
            // ユーザー名を書き込む
            string userName = "TestUser";
            _service.WriteUserName(userName);

            // INIファイルに正しく保存されているか確認
            string savedUserName = _service.ReadUserName();
            Assert.Equal(userName, savedUserName);
        }

        [Fact]
        public void WriteApiToken_ShouldSaveApiTokenToIniFile()
        {
            // APIトークンを書き込む
            string apiToken = "TestToken";
            _service.WriteApiToken(apiToken);

            // INIファイルに正しく保存されているか確認
            string savedApiToken = _service.ReadApiToken();
            Assert.Equal(apiToken, savedApiToken);
        }

        [Fact]
        public void ReadUserName_ShouldReturnEmptyStringWhenIniFileIsEmpty()
        {
            // 新しいINIファイルが作成されたとき、ユーザー名は空であることを確認
            string userName = _service.ReadUserName();
            Assert.Equal(string.Empty, userName);
        }

        [Fact]
        public void ReadApiToken_ShouldReturnEmptyStringWhenIniFileIsEmpty()
        {
            // 新しいINIファイルが作成されたとき、APIトークンは空であることを確認
            string apiToken = _service.ReadApiToken();
            Assert.Equal(string.Empty, apiToken);
        }

    }
}

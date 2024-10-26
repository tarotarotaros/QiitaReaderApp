using System;

namespace QiitaEditorApp.Services
{
    public class SettingFileService
    {
        private const string USER_SECTION_TEXT = "User";
        private const string USER_ITEM_KEY = "Username";
        private const string API_TOKNE_ITEM_KEY = "Apitoken";
        private readonly string SETTING_INI_FILE_PATH = "setting.json";
        private readonly JsonSettingsManager _jsonFileService;
        private readonly string _fullPath;

        public SettingFileService()
        {
            _fullPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, SETTING_INI_FILE_PATH);

            _jsonFileService = new JsonSettingsManager(_fullPath);
            if (_jsonFileService.ExistsKey(USER_ITEM_KEY) == false) _jsonFileService.Add(USER_ITEM_KEY, string.Empty);
            if (_jsonFileService.ExistsKey(API_TOKNE_ITEM_KEY) == false) _jsonFileService.Add(API_TOKNE_ITEM_KEY, string.Empty);
            
        }

        public void WriteUserName(string value)
        {
            _jsonFileService.Update(USER_ITEM_KEY, value);
        }

        public void WriteApiToken(string value)
        {
            _jsonFileService.Update(API_TOKNE_ITEM_KEY, value);
        }

        public string ReadUserName() 
        {
            return _jsonFileService.Read(USER_ITEM_KEY);
        }

        public string ReadApiToken()
        {
            return _jsonFileService.Read(API_TOKNE_ITEM_KEY);
        }
    }
}

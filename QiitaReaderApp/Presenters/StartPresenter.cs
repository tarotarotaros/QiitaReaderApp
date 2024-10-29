using QiitaReaderApp.Services;
using QiitaReaderApp.View;
using System;

namespace QiitaReaderApp.Presenters
{
    public class StartPresenter
    {
        private readonly IStartView _startView;
        private readonly SettingFileService _settingFileService;

        public StartPresenter(IStartView startView)
        {
            _startView = startView;

            _settingFileService = new SettingFileService();

            _startView.UserName = _settingFileService.ReadUserName();
            _startView.ApiToken = _settingFileService.ReadApiToken();

            if (!string.IsNullOrEmpty(_startView.UserName))
            {
                _startView.IsSave = true;
            }

            _startView.StartClicked += StartClicked;
        }

        private void StartClicked(object sender, EventArgs e)
        {
            if (_startView.IsSave)
            {
                _settingFileService.WriteUserName(_startView.UserName);
                _settingFileService.WriteApiToken(_startView.ApiToken);
            }

            _startView.SwitchEditorView();
        }
    }
}

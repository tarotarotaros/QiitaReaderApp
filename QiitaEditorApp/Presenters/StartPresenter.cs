using QiitaEditorApp.Services;
using QiitaEditorApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiitaEditorApp.Presenters
{
    public class StartPresenter
    {
        private readonly IStartView _startView;
        private readonly SettingFileService _settingFileService;

        public StartPresenter(IStartView startView)
        {
            _startView = startView;

            _settingFileService = new SettingFileService();

            _startView.StartClicked += StartClicked;
        }

        private void StartClicked(object sender, EventArgs e)
        {
            if (_startView.IsSave)
            {
                _settingFileService.WriteUserName(_startView.UserName);
                _settingFileService.WriteApiToken(_startView.ApiToken);
            }

            _startView.CloseView();



        }
    }
}

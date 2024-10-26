using QiitaEditorApp.Presenters;
using QiitaEditorApp.View;
using QiitaEditorApp.Views;

namespace QiitaEditorApp
{
    public enum ViewType
    {
        Start,
        Editor
    }

    public class SwitchViewApplicationContext : ApplicationContext
    {

        public SwitchViewApplicationContext()
        {
            // 初期画面の設定
            var view = new StartView(this);
            var presenter = new StartPresenter(view);
            this.MainForm = view;
        }

        /// <summary>
        /// 画面遷移処理
        /// </summary>
        /// <param name="nextForm">展開する画面</param>
        public void SwitchForm(Form nextForm)
        {
            var perviousForm = this.MainForm;
            this.MainForm = nextForm;

            perviousForm.Close();
            nextForm.Show();
        }

        /// <summary>
        /// 画面遷移処理
        /// </summary>
        /// <param name="viewType"></param>
        public void SwitchForm(ViewType viewType)
        {
            Form nextForm;
            switch (viewType)
            {
                case ViewType.Start:
                    var startView = new StartView(this);
                    var startPresenter = new StartPresenter(startView);
                    nextForm = startView;
                    break;
                case ViewType.Editor:
                    var editorView = new EditorView(this);
                    var editorPresenter = new EditorPresenter(editorView);
                    nextForm = editorView;
                    break;
                default:
                    return;
            }

            var perviousForm = this.MainForm;
            this.MainForm = nextForm;

            perviousForm.Close();
            nextForm.Show();
        }
    }
}

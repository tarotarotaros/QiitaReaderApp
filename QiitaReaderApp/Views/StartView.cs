using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace QiitaReaderApp.View
{

    public interface IStartView
    {
        event EventHandler StartClicked;
        void SwitchEditorView();

        string UserName { get; set; }
        string ApiToken { get; set; }
        bool IsSave { get; set; }
    }

    public partial class StartView : MaterialForm, IStartView
    {
        private SwitchViewApplicationContext context;

        private readonly MaterialSkinManager _materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        public StartView(SwitchViewApplicationContext applicationContext)
        {
            InitializeComponent();
            this.context = applicationContext;

            _materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            _materialSkinManager.AddFormToManage(this);
            _materialSkinManager.EnforceBackcolorOnAllComponents = true;
            _materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            _materialSkinManager.ColorScheme =
                new MaterialSkin.ColorScheme(
                    MaterialSkin.Primary.Green600,
                MaterialSkin.Primary.Green400,
                MaterialSkin.Primary.Green900,
                MaterialSkin.Accent.Green700,
                MaterialSkin.TextShade.BLACK);

        }

        public string UserName { get => this.UserNamelTextBox.Text; set => this.UserNamelTextBox.Text = value; }
        public string ApiToken { get => this.ApitokenTextBox.Text; set => this.ApitokenTextBox.Text = value; }
        public bool IsSave { get => this.IsSaveSwitch.Checked; set => this.IsSaveSwitch.Checked = value; }

    public event EventHandler StartClicked;

        public void SwitchEditorView()
        {
            this.context.SwitchForm(ViewType.Editor);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

using MaterialSkin;
using System;
using System.Windows.Forms;

namespace QiitaEditorApp.View
{

    public interface IStartView
    {
        event EventHandler StartClicked;
        void SwitchEditorView();

        string UserName { get; set; }
        string ApiToken { get; set; }
        bool IsSave { get; }
    }

    public partial class StartView : Form, IStartView
    {
        private SwitchViewApplicationContext context;

        private readonly MaterialSkinManager _materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        public StartView(SwitchViewApplicationContext applicationContext)
        {
            InitializeComponent();
            this.context = applicationContext;

            _materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            _materialSkinManager.EnforceBackcolorOnAllComponents = true;
            _materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            _materialSkinManager.ColorScheme =
                new MaterialSkin.ColorScheme(
                    MaterialSkin.Primary.BlueGrey800,
                MaterialSkin.Primary.BlueGrey900,
                MaterialSkin.Primary.BlueGrey500,
                MaterialSkin.Accent.LightBlue200,
                MaterialSkin.TextShade.WHITE);
        }

        public string UserName { get => this.UserNamelTextBox.Text; set => this.UserNamelTextBox.Text = value; }
        public string ApiToken { get => this.ApitokenTextBox.Text; set => this.ApitokenTextBox.Text = value; }

        public bool IsSave => this.IsSaveCheckBox.Checked;

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

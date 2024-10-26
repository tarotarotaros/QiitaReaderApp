using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QiitaEditorApp.View
{

    public interface IStartView
    {
        event EventHandler StartClicked;
        void CloseView();

        string UserName { get; set; }
        string ApiToken { get; set; }
        bool IsSave { get; }
    }

    public partial class StartView : Form, IStartView
    {

        private readonly MaterialSkinManager _materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        public StartView()
        {
            InitializeComponent();


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

        public void CloseView()
        {
            this.Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

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
using static QiitaEditorApp.Program;

namespace QiitaEditorApp.Views
{

    public interface IEditorView
    {

    }

    public partial class EditorView : MaterialForm, IEditorView
    {
        private readonly MaterialSkinManager _materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;

        public EditorView(SwitchViewApplicationContext applicationContext)
        {
            InitializeComponent();

            _materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            _materialSkinManager.EnforceBackcolorOnAllComponents = true;
            _materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            _materialSkinManager.ColorScheme =
                new MaterialSkin.ColorScheme(
                    MaterialSkin.Primary.BlueGrey800,
                MaterialSkin.Primary.BlueGrey900,
                MaterialSkin.Primary.BlueGrey500,
                MaterialSkin.Accent.DeepOrange700,
                MaterialSkin.TextShade.WHITE);
        }
    }
    
}

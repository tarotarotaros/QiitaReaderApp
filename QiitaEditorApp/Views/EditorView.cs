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
        public void AddCard(string title, DateTime createDate, List<string> tags, string url);
        public void ClearCards();
    }

    public partial class EditorView : MaterialForm, IEditorView
    {
        private readonly MaterialSkinManager _materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;

        private List<string> _cardKeys = new List<string>();

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

        public void AddCard(string title, DateTime createDate, List<string> tags, string url)
        {
            var card = new ArticleControl();
            card.Title = title;
            card.CreateDate = createDate;
            card.Tags = new System.Collections.ObjectModel.Collection<string>(tags);
            card.Url = url;

            card.Name = "XXXX" + _cardKeys.Count;

            _cardKeys.Add(card.Name);

            card.Location = new Point(10, 10 + (_cardKeys.Count - 1) * (150+20));

            this.cardListPanel.Controls.Add(card);
        }

        public void ClearCards()
        {
            _cardKeys.ForEach(key =>
            {
                var card = this.cardListPanel.Controls.Find(key, true).FirstOrDefault();
                if (card != null)
                {
                    this.Controls.Remove(card);
                    card.Dispose();
                }
            });

            _cardKeys.Clear();
        }
    }
    
}

using MaterialSkin;
using MaterialSkin.Controls;
using QiitaReaderApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace QiitaReaderApp.Views
{

    public interface IEditorView
    {
        void AddCard(string title, DateTime createDate, List<string> tags, string url, int viewCount, int favoriteCount, int commentCount);
        void ClearCards();
        void SetArticles(List<Article> articles);
    }

    public partial class EditorView : MaterialForm, IEditorView
    {
        private const int CARD_BETWEEN_SPACE = 20;
        private const int CARD_HEIGHT = 130;
        private const int CARD_LOCATION_X = 10;
        private const int CARD_FIRST_LOCATION_Y = 10;
        private const string CARD_NAME_WITHOUT_NUMBER = "ArticleCard";

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

        public void AddCard(string title, DateTime createDate, List<string> tags, string url, int viewCount, int favoriteCount, int commentCount)
        {
            var card = new ArticleControl();
            card.Name = CARD_NAME_WITHOUT_NUMBER + (_cardKeys.Count + 1).ToString();
            card.Title = title;
            card.CreateDate = createDate;
            card.Tags = new System.Collections.ObjectModel.Collection<string>(tags);
            card.Url = url;
            card.ViewCount = viewCount;
            card.FavoriteCount = favoriteCount;
            card.CommentCount = commentCount;
            card.Location = new Point(CARD_LOCATION_X, CARD_FIRST_LOCATION_Y + _cardKeys.Count * (CARD_HEIGHT + CARD_BETWEEN_SPACE));

            _cardKeys.Add(card.Name);
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

        public void SetArticles(List<Article> articles)
        {
            this.ArticleGraph.SetArticles(articles);
        }
    }
    
}

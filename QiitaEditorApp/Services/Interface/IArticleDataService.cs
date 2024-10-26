using QiitaEditorApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QiitaEditorApp.Services.Interface
{
    public interface IArticleDataService
    {
        void LoadSetting();
        Task<List<Article>> GetList();
    }
}

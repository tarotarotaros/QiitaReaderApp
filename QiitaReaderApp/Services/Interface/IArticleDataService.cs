using QiitaReaderApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QiitaReaderApp.Services.Interface
{
    public interface IArticleDataService
    {
        void LoadSetting();
        Task<List<Article>> GetList();
    }
}

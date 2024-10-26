using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiitaEditorApp.Models
{
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public List<string> Tags { get; set; }
        public string Tag { get; set; }
        public string Url { get; set; }
    }
}

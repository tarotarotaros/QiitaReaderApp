using QiitaEditorApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiitaEditorApp.Presenters
{
    public class EditorPresenter
    {
        private readonly IEditorView _editorView;

        public EditorPresenter(IEditorView editorView)
        {
            _editorView = editorView;
        }


    }
}

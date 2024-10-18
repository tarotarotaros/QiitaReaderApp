﻿using Prism.Mvvm;
using Prism.Navigation;

namespace QiitaEditorApp.Core.Mvvm
{
    public abstract class ViewModelBase : BindableBase, IDestructible
    {
        protected ViewModelBase()
        {

        }

        public virtual void Destroy()
        {

        }
    }
}
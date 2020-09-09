﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoViewer.UI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public ShellViewModel()
        {
            ActivateItem(IoC.Get<CryptoViewModel>());
        }

        public void ExitApplication()
        {
            TryClose();
        }
    }
}

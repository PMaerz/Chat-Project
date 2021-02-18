using NWS_Projekt.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using NWS_Projekt.ViewModels;

namespace NWS_Projekt.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        public ICommand UpdateViewCommand { get; set; }
        public LoginViewModel()
        {
           
        }
    }
}

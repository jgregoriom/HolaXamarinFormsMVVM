using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaXamarinFormsMVVM.ViewModels
{
    public class MainViewModel
    {
        private string _message;

        public MainViewModel()
        {
            Message = "Hola Xamarin.Forms MVVM!";
        }
        
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
    }

    
}

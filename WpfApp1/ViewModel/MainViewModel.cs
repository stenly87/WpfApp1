using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp1.View;

namespace WpfApp1.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        static MainViewModel instance;
        Page currentPage;

        public Page CurrentPage
        {
            get => currentPage;
            set
            {
                currentPage = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(nameof(CurrentPage)));
            }
        }

        public event PropertyChangedEventHandler?
            PropertyChanged;

        public static void ChangePage(Page page)
        {
            instance.CurrentPage = page;
        }

        public MainViewModel()
        {
            instance = this;
            CurrentPage = new GroupManagmentPage();
        }
    }
}

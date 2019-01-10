using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailContactPageMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailContactPageMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetailContactPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailContactPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailContactPageMenuItem> MenuItems { get; set; }
            
            public MasterDetailContactPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailContactPageMenuItem>(new[]
                {
                    new MasterDetailContactPageMenuItem { Id = 0, Title = "Page 1" },
                    new MasterDetailContactPageMenuItem { Id = 1, Title = "Page 2" },
                    new MasterDetailContactPageMenuItem { Id = 2, Title = "Page 3" },
                    new MasterDetailContactPageMenuItem { Id = 3, Title = "Page 4" },
                    new MasterDetailContactPageMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}
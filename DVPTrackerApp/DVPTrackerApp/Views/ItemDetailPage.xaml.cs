using DVPTrackerApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DVPTrackerApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
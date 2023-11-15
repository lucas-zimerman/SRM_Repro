using System.ComponentModel;
using SRM_Repro2.ViewModels;
using Xamarin.Forms;

namespace SRM_Repro2.Views
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
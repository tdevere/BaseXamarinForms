using System.ComponentModel;
using BaseXamarinForms.ViewModels;
using Xamarin.Forms;

namespace BaseXamarinForms.Views
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
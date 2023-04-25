using JGualpaS2D.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace JGualpaS2D.Views
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
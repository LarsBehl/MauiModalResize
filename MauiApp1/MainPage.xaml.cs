using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public async void OpenModal(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new ModalPage());
        }
    }
}

using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace MauiApp1
{
    public partial class ModalPage : ContentPage
    {
        public ModalPage()
        {
            InitializeComponent();
        }

        public void AddLabel(object sender, EventArgs e)
        {
            Console.WriteLine("Handle AddLabel");
            this.LabelList.Add(new Label() { Text = "Hello World" });
        }
    }
}
﻿using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Booky.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookDetailPage : ContentPage
    {
        private double _pageHeight;

        public BookDetailPage(string backgroundColor)
        {
            BackgroundColor = Color.FromHex(backgroundColor);
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            await cakeDetail.TranslateTo(0, header.Y, 500, Easing.SinOut);
            base.OnAppearing();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            _pageHeight = height;
            cakeDetail.TranslationY = _pageHeight * .65;
            base.OnSizeAllocated(width, height);
        }

        async void Handle_Tapped(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        void Handle_ScrollToRequested(object sender, Xamarin.Forms.ScrollToRequestEventArgs e)
        {
            
        }
    }
}

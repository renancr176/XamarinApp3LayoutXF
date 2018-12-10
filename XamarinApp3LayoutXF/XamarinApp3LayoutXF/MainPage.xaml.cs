using System;
using Xamarin.Forms;
using XamarinApp3LayoutXF.Layouts.Absolute;
using XamarinApp3LayoutXF.Layouts.Grid;
using XamarinApp3LayoutXF.Layouts.Relative;
using XamarinApp3LayoutXF.Layouts.Scroll;
using XamarinApp3LayoutXF.Layouts.Stack;

namespace XamarinApp3LayoutXF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoToStackPage(object sender, EventArgs args)
        {
            Navigation.PushAsync(new StackPage());
        }

        private void GoToGridPage(object sender, EventArgs args)
        {
            Navigation.PushAsync(new GridPage());
        }

        private void GoToAbsolutePage(object sender, EventArgs args)
        {
            Navigation.PushAsync(new AbsolutePage());
        }

        private void GoToRelativePage(object sender, EventArgs args)
        {
            Navigation.PushAsync(new RelativePage());
        }

        private void GoToScrollPage(object sender, EventArgs args)
        {
            Navigation.PushAsync(new ScrollPage());
        }
    }
}

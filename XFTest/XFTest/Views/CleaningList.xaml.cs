using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XFTest.ViewModels;
using Prism.Services.Dialogs;

namespace XFTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CleaningList : ContentPage
    {
        public CleaningList()
        {
            InitializeComponent();
            myCalender.IsVisible = true;
            FirstHandle();
            // BindingContext = new CleaningListViewModel(dialogService);
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            var state = width < 280 ? "Small" : width < 360 ? "Medium" : "Large";
            VisualStateManager.GoToState(PageHeading, state);
            
        }
        //first time list scorll down
        public void FirstHandle()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                var parent = (VisualElement)Parent;
                SizeRequest sizeRequest = myCalender.Measure(parent.Width, parent.Height);

                myCalender.TranslationY = -sizeRequest.Request.Height;

                myCalender.IsVisible = true;

                await myCalender.TranslateTo(0, 0, 500);
                await scorllist.TranslateTo(0, 120, 250);
            });
        }

        //calender get from top 
        public async void MyHandler(object sender, EventArgs args)
        {
            if (!myCalender.IsVisible)
            {
                var parent = (VisualElement)Parent;
                SizeRequest sizeRequest = myCalender.Measure(parent.Width, parent.Height);

                myCalender.TranslationY = -sizeRequest.Request.Height;

                myCalender.IsVisible = true;

                await myCalender.TranslateTo(0, 0, 500);
                await scorllist.TranslateTo(0, (sizeRequest.Request.Height-60), 250);

                //await App.Current.MainPage.DisplayAlert("aa", sizeRequest.Request.Height.ToString(), "Ok");
            }
        }

        //close calender
        private async Task AnimateOut()
        {
            await myCalender.TranslateTo(0, -myCalender.Height, 500);
            await scorllist.TranslateTo(0, 0, 250);
            myCalender.IsVisible = false;
        }

        public async void MyHandler2(object sender, EventArgs args)
        {
            if (myCalender.IsVisible)
            {
                await AnimateOut();
            }
        }

    }
}
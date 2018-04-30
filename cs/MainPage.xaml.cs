using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
        }

        public void hireStudio(object sender, EventArgs args)
        {
            Toast.MakeText(Forms.Context, "Studio Hire option", ToastLength.Short).Show();
        }

        public void getQuote(object sender, EventArgs args)
        {
            Toast.MakeText(Forms.Context, "Get a Quote option", ToastLength.Short).Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace mrealtime
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new mrealtime.MainPage();
            MainPage = new mrealtime.Views.RealTimePage();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

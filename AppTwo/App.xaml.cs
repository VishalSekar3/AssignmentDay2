using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTwo
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new QuotesPage();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}

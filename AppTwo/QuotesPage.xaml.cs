using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTwo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotesPage : ContentPage
	{
		private string[] str1 = 
		{ "When there is a will there is a way.", "You miss 100% of the shots you don't take", 
			" An eye for an eye will make the whole world blind", "The Only way to do great work is to love what you do.", " The Best way to Predict the future is to invent it" };

		private int _qIndex = 0;

		public string CurrentQuotes => str1[_qIndex];
		public QuotesPage()
		{
			InitializeComponent();
			BindingContext= this;
		}

		
		private void Button_Clicked(object sender, EventArgs e)
		{
			_qIndex++;
			if (_qIndex >= str1.Length)
			{
				_qIndex = 0;
			}
			OnPropertyChanged(nameof(CurrentQuotes));


		}
	}
}
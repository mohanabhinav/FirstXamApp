using System;

using Xamarin.Forms;

namespace FirstXamApp
{
	public class FirstXamAppNavigationPage : ContentPage
	{
		public FirstXamAppNavigationPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}



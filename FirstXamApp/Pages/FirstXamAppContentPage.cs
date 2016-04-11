using System;

using Xamarin.Forms;

namespace FirstXamApp
{
	/// <summary>
	/// First xam app content page.
	/// </summary>
	public class FirstXamAppContentPage : ContentPage
	{
		StackLayout parent = new StackLayout {
			Spacing = 0,
			VerticalOptions = LayoutOptions.Center};
		Label output = new Label{ Text = ""};

		public FirstXamAppContentPage ()
		{
			var button = new ShadedButton {	Text = "click me", TextColor=Xamarin.Forms.Color.White };
			button.Clicked += clickMeClicked;
//			Content = new StackLayout { 
//				Children = {
//					new Label { Text = "Hello ContentPage" },
//					button 
//				}
//		};
			parent.Children.Add(new Label{ Text = "Hello" });
			parent.Children.Add(new Label{ Text = "World" });

			parent.Children.Add(button);
			parent.Children.Add(output);

			//test checkin 3
			Content = parent;
		}


		/// <summary>
		/// Click Event handler for the "Clicks me" button.
		/// </summary>
		/// <param name="o">O.</param>
		/// <param name="e">E.</param>
		void clickMeClicked (object o, EventArgs e)
		{
			if (output.Text.Trim().Length == 0)
				output.Text = "you clicked me";
			if(output.Text.Trim().Length >= 100)
				output.Text += "Stop clicking me!!!";
			else
				output.Text += " again";

		}

	}
}



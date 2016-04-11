using System;

using Xamarin.Forms;

namespace FirstXamApp
{
	public class LayoutsPage : ContentPage
	{
		public LayoutsPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "StackLayout" },
					new Button {Text = "button"},
					new Entry {Text = "entry"},
					new ListView { }
				}
			};

			Content = new AbsoluteLayout{
			};

			Content = new RelativeLayout{
			};

			Content = new Grid{
			};

			Content = new ContentView{
			};

			Content = new ScrollView{
			};

			Content = new Frame{
			};

		}
	}
}



using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using FirstXamApp;
using FirstXamApp.iOS;

[assembly:ExportRendererAttribute(typeof(ShadedButton), typeof(ShadedButtonRender))]
namespace FirstXamApp.iOS
{
	public class ShadedButtonRender : ButtonRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e){
			base.OnElementChanged (e);

			if (Control != null) {
				Control.BackgroundColor = UIColor.Gray;
			}
		}
	}
}


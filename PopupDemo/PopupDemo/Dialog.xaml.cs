using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms.Xaml;

namespace PopupDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Dialog : PopupPage
	{
		public Dialog ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
        }
	}
}
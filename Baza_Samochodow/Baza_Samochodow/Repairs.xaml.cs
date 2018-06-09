using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Baza_Samochodow
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Repairs : ContentPage
	{
		public Repairs ()
		{
			InitializeComponent ();
		}

        private void btnReturn(object sender, EventArgs args)
        {
            App.Current.MainPage = new MainPage();
        }
    }
}
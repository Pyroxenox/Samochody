using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Baza_Samochodow
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        void OnExpenseChosen(object sender, EventArgs args)
        {
            Picker typePicker = (Picker)sender;

            int type = typePicker.SelectedIndex;

            switch(type)
            {
                case 0:
                    {
                        App.Current.MainPage = new Refuel();
                        break;
                    }
                case 1:
                    {
                        App.Current.MainPage = new Repairs();
                        break;
                    }
                case 2:
                    {
                        App.Current.MainPage = new Inspection();
                        break;
                    }
                case 3:
                    {
                        App.Current.MainPage = new OC();
                        break;
                    }
            }
        }
    }
}

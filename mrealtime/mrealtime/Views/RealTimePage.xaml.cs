using mrealtime.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mrealtime.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RealTimePage : ContentPage
	{
        DBFire db;
		public RealTimePage ()
		{
			InitializeComponent ();
            db = new DBFire();
            _lstData.BindingContext = db.getTdpData();
            /*foreach (var item in db.getTdpData())
            {
                System.Console.WriteLine("stop plz item: " + item.nombre);
            } */
        }
	}
}
using System;
using Gtk;

namespace Raspored
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Application.Init();
			MainWindow win = new MainWindow();
			DB.OtvoriKonekciju();
			Skola.ucionice_lista = DBUcionica.DohvatiSve_Ucionice();
			Skola.predavaci_lista = DBPredavac.DohvatiSve_Predavace();
			win.Show();
			Application.Run();
		}
	}
}

using System;
using Gtk;

namespace Raspored
{
	public partial class DodajUcionicuWindow : Gtk.Window
	{
		
		public DodajUcionicuWindow() : base(Gtk.WindowType.Toplevel)
		{
			this.Build();

		}

		protected void OnButtonOdustaniClicked(object sender, EventArgs e)
		{
			this.Destroy();
		}

		protected void OnButtonSpremiClicked(object sender, EventArgs e)
		{
			int kapacitet;
			if (entry_naziv.Text.Length > 2 && entry_kapacitet.Text != "" && Int32.TryParse(entry_kapacitet.Text, out kapacitet)) 
			{
				try
				{
					DBUcionica.Dodaj(new Ucionica(entry_naziv.Text, entry_kapacitet.Text, entry_dodatniKomentar.Text)); // Dodamo učionicu u bazu
					Skola.ucionice_lista.Add(DBUcionica.Dohvati_Ucionicu(entry_naziv.Text)); // Iz baze dohvaćamo učionicu s IDom kreiranim na bazi te ga stavljamo u listu
				}
				catch
				{
					Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Ucionica pod upisanim nazivom vec postoji!");
					d.Run();
					d.Destroy();
				}
				this.Destroy();
			}
			else
			{
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Nisu unesena sva polja!");
				d.Run();
				d.Destroy();
			}
		}
	} // Kraj klase DodajUcionicuWindow
}

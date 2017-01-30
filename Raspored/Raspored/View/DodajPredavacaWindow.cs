using System;
using Gtk;

namespace Raspored
{
	public partial class DodajPredavacaWindow : Gtk.Window
	{
		public DodajPredavacaWindow() : base(Gtk.WindowType.Toplevel)
		{
			this.Build();
		}

		protected void OnButtonOdustaniClicked(object sender, EventArgs e)
		{
			this.Destroy();
		}

		protected void OnButtonSpremiClicked(object sender, EventArgs e)
		{
			long OIB;
			if (entry_ime.Text.Length > 2 && entry_prezime.Text.Length > 2 && entry_adresa.Text.Length > 2 && entry_OIB.Text.Length == 11 && Int64.TryParse(entry_OIB.Text, out OIB))
			{
				DBPredavac.Dodaj(new Predavac(entry_ime.Text, entry_prezime.Text, entry_adresa.Text, entry_OIB.Text));
				Skola.predavaci_lista.Add(DBPredavac.Dohvati_Predavaca(entry_OIB.Text)); // Puni listu u programu iz baze i postavlja ID
				this.Destroy();
			}
			else 
			{
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Nisu unesena sva polja!");
				d.Run();
				d.Destroy();
			}
		}
	}
}

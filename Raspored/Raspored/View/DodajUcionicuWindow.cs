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
			if (entry_naziv.Text.Length > 2 && entry_kapacitet.Text != "" && entry_dodatniKomentar.Text.Length > 2) 
			{
				DBUcionica.Dodaj(new Ucionica(entry_naziv.Text, entry_kapacitet.Text, entry_dodatniKomentar.Text)); // Dodamo učionicu u bazu
				Skola.ucionice_lista.Add(DBUcionica.Dohvati_Ucionicu(entry_naziv.Text)); // Iz baze dohvaćamo učionicu s IDom kreiranim na bazi te ga stavljamo u listu
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

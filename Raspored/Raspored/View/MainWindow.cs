using System;
using System.Data;
using Gtk;
using Mono.Data.Sqlite;
using Raspored;

public partial class MainWindow : Gtk.Window
{
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
		DB.OtvoriKonekciju();
		Skola.ucionice_lista = DBUcionica.DohvatiSve_Ucionice();
		Skola.predavaci_lista = DBPredavac.DohvatiSve_Predavace();
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		DB.ZatvoriKonekciju();
		Application.Quit();
		a.RetVal = true;
	}

	protected void OnButtonIzlazClicked(object sender, EventArgs e)
	{
		DB.ZatvoriKonekciju();
		this.Destroy();
		Application.Quit();
	}

	protected void OnButtonDodajUcionicuClicked(object sender, EventArgs e)
	{
		DodajUcionicuWindow ucionicaWindow = new DodajUcionicuWindow();
	}

	protected void OnButtonDodajPredavacaClicked(object sender, EventArgs e)
	{
		DodajPredavacaWindow predavacWindow = new DodajPredavacaWindow();
	}

	protected void OnButtonZauzmiUcionicuClicked(object sender, EventArgs e)
	{
		ZauzmiUcionuWindow zauzmiWindow = new ZauzmiUcionuWindow();
	}

	protected void OnButtonPregledajUcionicuClicked(object sender, EventArgs e)
	{
		PregledajUcioneWindow UcionaWindow = new PregledajUcioneWindow();

	}

	protected void OnButtonPregledajPredavaceClicked(object sender, EventArgs e)
	{
		PregledajPredavacaWindow PredavacWindow = new PregledajPredavacaWindow();

	}

	protected void OnButtonPregledRasporedaClicked(object sender, EventArgs e)
	{
		PregledajTermineWindow PregledajWindow = new PregledajTermineWindow();
	}

	protected void OnButtonNoviSemestarClicked(object sender, EventArgs e)
	{
		Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Question, ButtonsType.YesNo, "Jeste li sigurni da želite napraviti novi semestar?");

		var odgovor = (Gtk.ResponseType)d.Run();
		d.Destroy();
		if (odgovor == Gtk.ResponseType.Yes)
		{
			foreach (var a in Skola.ucionice_lista) 
			{
				a.raspored_pamti_IDpredavac = new int[15, 5] { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
				a.polje_IDpredavaci = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,";
				DBUcionica.Update_redak(a.polje_IDpredavaci, a.naziv);
			} // Resertira u ucionicama dvodimenzionalna polja na 0
			foreach (var a in Skola.predavaci_lista)
			{
				a.raspored_pamti_IDuciona = new int[15, 5] { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
				a.polje_IDucionice = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,";
				DBPredavac.Update_redak(a.polje_IDucionice, a.OIB);
			} // Resertira predavacima dvodimenzionalna polja na 0

			Dialog d2 = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Sve rezervacije su se poništile. Program je spreman za novi semestar.");
			d2.Run();
			d2.Destroy();
		}
	}
}

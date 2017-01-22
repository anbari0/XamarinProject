using System;
using Gtk;

namespace Raspored
{
	public partial class ZauzmiUcionuWindow : Gtk.Window
	{
		UcionicaNodeStore ucioniceNodeStore = new UcionicaNodeStore();
		PredavacNodeStore predavaciNodeStore = new PredavacNodeStore();

		public ZauzmiUcionuWindow() : base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			nodeview_odabirUcionice.AppendColumn("Naziv", new CellRendererText(), "text", 0).MinWidth=200;
			nodeview_odabirUcionice.AppendColumn("Kapacitet", new CellRendererText(), "text", 1).MinWidth=100;
			nodeview_odabirUcionice.AppendColumn("Dodatni komentar", new CellRendererText(), "text", 2).MinWidth=200;

			nodeview_odabirPredavaca.AppendColumn("Ime", new CellRendererText(), "text", 0).MinWidth=100;
			nodeview_odabirPredavaca.AppendColumn("Prezime", new CellRendererText(), "text", 1).MinWidth=200;
			nodeview_odabirPredavaca.AppendColumn("Adresa", new CellRendererText(), "text", 2).MinWidth=200;
			nodeview_odabirPredavaca.AppendColumn("OIB", new CellRendererText(), "text", 3);

			ucioniceNodeStore.Dodaj(Raspored.Skola.ucionice_lista);
			nodeview_odabirUcionice.NodeStore = ucioniceNodeStore;

			predavaciNodeStore.Dodaj(Raspored.Skola.predavaci_lista);
			nodeview_odabirPredavaca.NodeStore = predavaciNodeStore;
		}

		protected void OnButtonDaljeClicked(object sender, EventArgs e)
		{
			var var_ucionica = (UcionicaNode)nodeview_odabirUcionice.NodeSelection.SelectedNode;
			var var_predavac = (PredavacNode)nodeview_odabirPredavaca.NodeSelection.SelectedNode;

			if (var_ucionica != null && var_predavac != null)
			{
				ZauzmiTerminWindow zauzTerminWindow = new ZauzmiTerminWindow(Skola.vraca_predavaca(var_predavac.ime, var_predavac.prezime, var_predavac.adresa), Skola.vraca_ucionicu(var_ucionica.naziv));
				// Predajemo prozoru dalje predavaca selektiranog i ucionicu
			}
			else
			{ 
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Niste odabali učionicu i predavača!");
				d.Run();
				d.Destroy();
			} // Provjerava je li selektiran predavac i ucionica da bi mogli ici dalje
		} // Metoda za button dalje

		protected void OnButtonOdustaniClicked(object sender, EventArgs e)
		{
			this.Destroy();
		}

	}
}

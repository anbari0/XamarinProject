using System;
using Gtk;

namespace Raspored
{
	public partial class PregledajPredavacaWindow : Gtk.Window
	{
		PredavacNodeStore predavacNodeStore = new PredavacNodeStore();

		public PregledajPredavacaWindow() : base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			nodeview_predavaci.AppendColumn("Ime", new CellRendererText(), "text", 0);
			nodeview_predavaci.AppendColumn("Prezime", new CellRendererText(), "text", 1);
			nodeview_predavaci.AppendColumn("Adresa", new CellRendererText(), "text", 2);
			nodeview_predavaci.AppendColumn("OIB", new CellRendererText(), "text", 3);

			predavacNodeStore.Dodaj(Raspored.Skola.predavaci_lista);
			nodeview_predavaci.NodeStore = predavacNodeStore;
		}

		protected void OnButtonNatragClicked(object sender, EventArgs e)
		{
			this.Destroy();
		}

		protected void OnButtonIzbrisiPredavacaClicked(object sender, EventArgs e)
		{
			int ID=0;
			var var_predavac = (PredavacNode)nodeview_predavaci.NodeSelection.SelectedNode;
			if (var_predavac != null)
			{
				nodeview_predavaci.NodeStore.Clear();
				predavacNodeStore.Clear();
				foreach (var a in Skola.predavaci_lista)
				{
					if (a.prezime == var_predavac.prezime && a.OIB == var_predavac.OIB)
					{
						ID = a.ID;
						DBPredavac.Izbrisi_redak(a.OIB);
						Skola.predavaci_lista.Remove(a);
						predavacNodeStore.Dodaj(Raspored.Skola.predavaci_lista);
						break;
					}
				}
				foreach (var a in Skola.ucionice_lista)
				{
					for (int i = 0; i < 15; ++i)
					{
						for (int j = 0; j < 5; ++j)
						{
							if (a.raspored_pamti_IDpredavac[i, j] == ID) a.raspored_pamti_IDpredavac[i, j] = 0;
						}
					}
					DBUcionica.Update_redak(Skola.algoritamPoljetoString(a.raspored_pamti_IDpredavac), a.naziv);
				}
			} // Kraj IF-a
			else 
			{
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Niste odabali predavača!");
				d.Run();
				d.Destroy();
			}
		} // Brisemo sve IDeve u dvodimenzionalnom polju od ucionica gdje je ID profesora izbrisanog u polju
	}
}

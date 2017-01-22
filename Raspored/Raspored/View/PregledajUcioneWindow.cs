using System;
using Gtk;

namespace Raspored
{
	public partial class PregledajUcioneWindow : Gtk.Window
	{
		UcionicaNodeStore ucionaNodeStore = new UcionicaNodeStore();

		public PregledajUcioneWindow() : base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			nodeview_Ucionica.AppendColumn("Naziv", new CellRendererText(), "text", 0).MinWidth = 150;
			nodeview_Ucionica.AppendColumn("Kapacitet", new CellRendererText(), "text", 1).MinWidth = 100;
			nodeview_Ucionica.AppendColumn("Komentar", new CellRendererText(), "text", 2).MinWidth = 350;

			ucionaNodeStore.Dodaj(Raspored.Skola.ucionice_lista);
			nodeview_Ucionica.NodeStore = ucionaNodeStore;
		}

		protected void OnButtonNatragClicked(object sender, EventArgs e)
		{
			this.Destroy();
		}

		protected void OnButtonIzbrisiUcionicuClicked(object sender, EventArgs e)
		{
			int ID = 0;
			var var_ucionica = (UcionicaNode)nodeview_Ucionica.NodeSelection.SelectedNode;
			if (var_ucionica != null)
			{
				nodeview_Ucionica.NodeStore.Clear();
				ucionaNodeStore.Clear();
				foreach (var a in Skola.ucionice_lista)
				{
					if (a.naziv == var_ucionica.naziv && a.kapacitet == var_ucionica.kapacitet && a.kapacitet == var_ucionica.kapacitet)
					{
						ID = a.ID;
						DBUcionica.Izbrisi_redak(a.naziv);
						Skola.ucionice_lista.Remove(a);
						ucionaNodeStore.Dodaj(Raspored.Skola.ucionice_lista);
						break;
					}
				}
				foreach (var a in Skola.predavaci_lista)
				{
					for (int i = 0; i < 15; ++i)
					{
						for (int j = 0; j < 5; ++j)
						{
							if (a.raspored_pamti_IDuciona[i, j] == ID) a.raspored_pamti_IDuciona[i, j] = 0;
						}
					}
					DBUcionica.Update_redak(Skola.algoritamPoljetoString(a.raspored_pamti_IDuciona), a.OIB);
				}
			} // Kraj IF-a
			else 
			{
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, "Niste odabali učionicu!");
				d.Run();
				d.Destroy();
			}
		}
	}
}

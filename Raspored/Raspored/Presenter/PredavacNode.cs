using System;

namespace Raspored
{
	public class PredavacNode : Gtk.TreeNode
	{

		[Gtk.TreeNodeValue(Column = 0)]
		public string ime;

		[Gtk.TreeNodeValue(Column = 1)]
		public string prezime;

		[Gtk.TreeNodeValue(Column = 2)]
		public string adresa;

		[Gtk.TreeNodeValue(Column = 3)]
		public string OIB;

		public PredavacNode(Predavac a)
		{
			ime = a.ime;
			prezime = a.prezime;
			adresa = a.adresa;
			OIB = a.OIB;
		} // Konstruktor koji sprema iz klase Predavac a u nodove

	} // Kraj klase
}

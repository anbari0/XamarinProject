using System;

namespace Raspored
{
	public class UcionicaNode : Gtk.TreeNode
	{
		[Gtk.TreeNodeValue(Column = 0)]
		public string naziv;

		[Gtk.TreeNodeValue(Column = 1)]
		public string kapacitet;

		[Gtk.TreeNodeValue(Column = 2)]
		public string komentar;

		public UcionicaNode(Ucionica a)
		{
			naziv = a.naziv;
			kapacitet = a.kapacitet;
			komentar = a.komentar;
		} // Konstruktor koji sprema iz ucionice a u nodove

	} // Kraj klase
}

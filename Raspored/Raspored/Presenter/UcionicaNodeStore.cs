using System;
using System.Collections.Generic;

namespace Raspored
{
	public class UcionicaNodeStore : Gtk.NodeStore
	{
		public UcionicaNodeStore() : base(typeof(UcionicaNode))
		{
		}

		public void Add(Ucionica a) 
		{
			this.AddNode(new UcionicaNode(a));
		} // Dodajemo ucionicu

		public void Dodaj(List<Ucionica> a) 
		{
			foreach (var temp in a) 
			{
				Add(temp);
			}
		} // Dodajemo listu ucionica

	} // Kraj klase
}

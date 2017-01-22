using System;
using System.Collections.Generic;

namespace Raspored
{
	public class PredavacNodeStore : Gtk.NodeStore
	{
		public PredavacNodeStore() : base(typeof(PredavacNode))
		{
		}

		public void Add(Predavac a)
		{
			this.AddNode(new PredavacNode(a));
		} // Dodajemo predavaca

		public void Dodaj(List<Predavac> a)
		{
			foreach (var temp in a)
			{
				Add(temp);
			}
		} // Dodajemo listu predavaca
	}
}

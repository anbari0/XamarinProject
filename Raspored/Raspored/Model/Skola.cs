using System;
using System.Collections.Generic;

namespace Raspored
{
	public static class Skola
	{
		public static List<Predavac> predavaci_lista = new List<Predavac>();
		public static List<Ucionica> ucionice_lista = new List<Ucionica>();

		public static void dodaj_predavaca(Predavac a) 
		{
			predavaci_lista.Add(a);
		} // Dodajemo predavaca u listu

		public static void dodaj_ucionicu(Ucionica a)
		{
			ucionice_lista.Add(a);
		} // Dodajemo ucionicu u listu


		public static Predavac vraca_predavaca(string ime, string prezime, string adresa)
		{
			foreach (var temp in predavaci_lista)
			{
				if (ime.ToUpper() == temp.ime.ToUpper() && prezime.ToUpper() == temp.prezime.ToUpper() && adresa.ToUpper() == temp.adresa.ToUpper())
				{
					return temp;
				}
			}
			return null;
		} // Vraca predavaca

		public static Ucionica vraca_ucionicu(string naziv)
		{
			foreach (var temp in ucionice_lista)
			{
				if (temp.naziv == naziv)
				{
					return temp;
				}
			}
			return null;
		} // Vraca ucionicu ako je naziv jednak argumentu 'naziv'

		public static Predavac vratiPredavaca_ID(int ID)
		{
			if (ID == 0) return null;
			foreach (var a in predavaci_lista) 
			{
				if (ID == a.ID) return a;
			}
			return null;
		} // Vraca ID od profesora

		public static string algoritamPoljetoString(int [,]polje) 
		{
			string temp = "";
			for (int i = 0; i < 15; ++i)
			{
				for (int j = 0; j < 5; ++j)
				{
					temp = temp + polje[i, j].ToString() + ',';
				}
			}
			return temp;
		} // Algoritam pretvara polje u string koji spremamo u bazu
	}
}

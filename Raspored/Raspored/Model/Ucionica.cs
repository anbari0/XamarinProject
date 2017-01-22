using System;
namespace Raspored
{
	public class Ucionica
	{
		//public static int sekvenca = 1;
		public int ID;
		public string naziv;
		public string kapacitet;
		public string komentar;
		public string polje_IDpredavaci = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,";
		public int[,] raspored_pamti_IDpredavac = new int[15, 5] { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };

		public Ucionica(string naziv, string kapacitet, string komentar)
		{
			this.naziv = naziv;
			this.kapacitet = kapacitet;
			this.komentar = komentar;
		}

		public Ucionica(int ID, string naziv, string kapacitet, string komentar, string polje_IDpredavaci)
		{
			this.ID = ID;
			this.naziv = naziv;
			this.kapacitet = kapacitet;
			this.komentar = komentar;
			this.polje_IDpredavaci = polje_IDpredavaci;

			int brojac = 0;
			string temp = "";
			for (int i = 0; i < 15; ++i)
			{
				for (int j = 0; j < 5; ++j)
				{
					while (polje_IDpredavaci[brojac] != ',')
					{
						temp = temp + polje_IDpredavaci[brojac];
						brojac++;
					}
					brojac++;
					raspored_pamti_IDpredavac[i, j] = Int32.Parse(temp);
					temp = "";
				}
			} // Algoritam za pretvaranje stringa u dvodimenzionalno polje
		}
	}
}
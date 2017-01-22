using System;
namespace Raspored
{
	public class Predavac
	{
		//public static int sekvenca = 1;
		public int ID;
		public string ime;
		public string prezime;
		public string adresa;
		public string OIB;

		public string polje_IDucionice = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,";
		public int[,] raspored_pamti_IDuciona = new int[15,5] {{ 0, 0, 0, 0, 0},{ 0, 0, 0, 0, 0 },{ 0, 0, 0, 0, 0 },{ 0, 0, 0, 0, 0 },{ 0, 0, 0, 0, 0 },{ 0, 0, 0, 0, 0 },{ 0, 0, 0, 0, 0 },{ 0, 0, 0, 0, 0 },{ 0, 0, 0, 0, 0 },{ 0, 0, 0, 0, 0 },{ 0, 0, 0, 0, 0},{ 0, 0, 0, 0, 0},{ 0, 0, 0, 0, 0},{ 0, 0, 0, 0, 0},{ 0, 0, 0, 0, 0}};


		public Predavac(string ime, string prezime, string adresa, string OIB)
		{
			this.ime = ime;
			this.prezime = prezime;
			this.adresa = adresa;
			this.OIB = OIB;
		}

		public Predavac(int ID, string ime, string prezime, string adresa, string OIB, string polje_IDucionice)
		{
			this.ID = ID;
			this.ime = ime;
			this.prezime = prezime;
			this.adresa = adresa;
			this.OIB = OIB;
			this.polje_IDucionice = polje_IDucionice;

			int brojac = 0;
			string temp="";
			for (int i = 0; i < 15; ++i)
			{
				for (int j = 0; j < 5; ++j)
				{
					while (polje_IDucionice[brojac] != ',') 
					{
						temp = temp + polje_IDucionice[brojac];
						brojac++;
					}
					brojac++;
					raspored_pamti_IDuciona[i, j] = Int32.Parse(temp);
					temp = "";
				}
			} // Algoritam za pretvaranje stringa u dvodimenzionalno polje
		}

		/*public static algoritam_stringTopolje() 
		{ 
			
		}*/
	}
}

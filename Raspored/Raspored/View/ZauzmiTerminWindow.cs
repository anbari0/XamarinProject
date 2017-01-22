using System;
using Gtk;

namespace Raspored
{
	public partial class ZauzmiTerminWindow : Gtk.Window
	{
		public bool[,] pomocno_polje = new bool[15, 5];


		private Predavac _predavac;
		private Ucionica _ucionica;


		public ZauzmiTerminWindow(Predavac _predavac, Ucionica _ucionica) : base(Gtk.WindowType.Toplevel)
		{
			this.Build();
			this._predavac = _predavac;
			this._ucionica = _ucionica;
			provjera_polja_predavac_ucionice();
			for (int i = 0; i < 15;++i) 
			{
				for (int j = 0; j < 5;++j) 
				{
					pomocno_polje[i, j] = false;
				}
			}

		} // Konstruktor

		protected void OnButtonClicked(object sender, EventArgs e)
		{
			var dugme = (Button)sender;
			dugme.State = Gtk.StateType.Insensitive;
			switch (dugme.Name) 
			{
				case "button00_":
					pomocno_polje[0, 0] = true;
					break;
				case "button10_":
					pomocno_polje[1,0] = true;
				break;
				case "button20_":
					pomocno_polje[2,0] = true;
				break;	
				case "button30_":
					pomocno_polje[3,0] = true;
				break;
				case "button40_":
					pomocno_polje[4,0] = true;
				break;
				case "button50_":
					pomocno_polje[5,0] = true;
				break;
				case "button60_":
					pomocno_polje[6,0] = true;
				break; // Ponedjeljak - prijepodne
				case "button70_":
					pomocno_polje[7,0] = true;
					break;
				case "button80_":
					pomocno_polje[8,0] = true;
					break;
				case "button90_":
					pomocno_polje[9,0] = true;
					break;
				case "button100_":
					pomocno_polje[10,0] = true;
					break;
				case "button110_":
					pomocno_polje[11,0] = true;
					break;
				case "button120_":
					pomocno_polje[12,0] = true;
					break;
				case "button130_":
					pomocno_polje[13,0] = true;
					break;
				case "button140_":
					pomocno_polje[14,0] = true;
					break; // Ponedjeljak - posljepodne
					
				case "button01_":
					pomocno_polje[0,1] = true;
					break;
				case "button11_":
					pomocno_polje[1,1] = true;
					break;
				case "button21_":
					pomocno_polje[2,1] = true;
					break;
				case "button31_":
					pomocno_polje[3,1] = true;
					break;
				case "button41_":
					pomocno_polje[4,1] = true;
					break;
				case "button51_":
					pomocno_polje[5,1] = true;
					break;
				case "button61_":
					pomocno_polje[6,1] = true;
					break; // Utorak - prijepodne
				case "button71_":
					pomocno_polje[7,1] = true;
					break;
				case "button81_":
					pomocno_polje[7,1] = true;
					break;
				case "button91_":
					pomocno_polje[9,1] = true;
					break;
				case "button101_":
					pomocno_polje[10,1] = true;
					break;
				case "button111_":
					pomocno_polje[11,1] = true;
					break;
				case "button121_":
					pomocno_polje[12,1] = true;
					break;
				case "button131_":
					pomocno_polje[13,1] = true;
					break;
				case "button141_":
					pomocno_polje[14,1] = true;
					break; // Utorak - posljepodne

				case "button02_":
					pomocno_polje[0,2] = true;
					break;
				case "button12_":
					pomocno_polje[1,2] = true;
					break;
				case "button22_":
					pomocno_polje[2,2] = true;
					break;
				case "button32_":
					pomocno_polje[3,2] = true;
					break;
				case "button42_":
					pomocno_polje[4,2] = true;
					break;
				case "button52_":
					pomocno_polje[5,2] = true;
					break;
				case "button62_":
					pomocno_polje[6,2] = true;
					break; // Srijeda - prijepodne
				case "button72_":
					pomocno_polje[7,2] = true;
					break;
				case "button82_":
					pomocno_polje[8,2] = true;
					break;
				case "button92_":
					pomocno_polje[9,2] = true;
					break;
				case "button102_":
					pomocno_polje[10,2] = true;
					break;
				case "button112_":
					pomocno_polje[11,2] = true;
					break;
				case "button122_":
					pomocno_polje[12,2] = true;
					break;
				case "button132_":
					pomocno_polje[13,2] = true;
					break;
				case "button142_":
					pomocno_polje[14,2] = true;
					break; // Srijeda - posljepodne

				case "button03_":
					pomocno_polje[0,3] = true;
					break;
				case "button13_":
					pomocno_polje[1,3] = true;
					break;
				case "button23_":
					pomocno_polje[2,3] = true;
					break;
				case "button33_":
					pomocno_polje[3,3] = true;
					break;
				case "button43_":
					pomocno_polje[4,3] = true;
					break;
				case "button53_":
					pomocno_polje[5,3] = true;
					break;
				case "button63_":
					pomocno_polje[6,3] = true;
					break; // Četvrtak - prijepodne
				case "button73_":
					pomocno_polje[7,3] = true;
					break;
				case "button83_":
					pomocno_polje[8,3] = true;
					break;
				case "button93_":
					pomocno_polje[9,3] = true;
					break;
				case "button103_":
					pomocno_polje[10,3] = true;
					break;
				case "button113_":
					pomocno_polje[11,3] = true;
					break;
				case "button123_":
					pomocno_polje[12,3] = true;
					break;
				case "button133_":
					pomocno_polje[13,3] = true;
					break;
				case "button143_":
					pomocno_polje[14,3] = true;
					break; // Četvrtak - posljepodne

				case "button04_":
					pomocno_polje[0,4] = true;
					break;
				case "button14_":
					pomocno_polje[1,4] = true;
					break;
				case "button24_":
					pomocno_polje[2,4] = true;
					break;
				case "button34_":
					pomocno_polje[3,4] = true;
					break;
				case "button44_":
					pomocno_polje[4,4] = true;
					break;
				case "button54_":
					pomocno_polje[5,4] = true;
					break;
				case "button64_":
					pomocno_polje[6,4] = true;
					break; // Petak - prijepodne
				case "button74_":
					pomocno_polje[7,4] = true;
					break;
				case "button84_":
					pomocno_polje[8,4] = true;
					break;
				case "button94_":
					pomocno_polje[9,4] = true;
					break;
				case "button104_":
					pomocno_polje[10,4] = true;
					break;
				case "button114_":
					pomocno_polje[11,4] = true;
					break;
				case "button124_":
					pomocno_polje[12,4] = true;
					break;
				case "button134_":
					pomocno_polje[13,4] = true;
					break;
				case "button144_":
					pomocno_polje[14,4] = true;
					break; // Petak - posljepodne
			}

		} // Kada kliknemo na button oznacimo da je button aktiviran

		public void provjera_polja_predavac_ucionice ()
		{
			for (int i = 0; i < 15;++i) 
			{
				for (int j = 0; j < 5; ++j) 
				{ 
					if (_predavac.raspored_pamti_IDuciona[i,j] != 0 || _ucionica.raspored_pamti_IDpredavac[i,j] != 0)
					{
						switch (i.ToString()+j.ToString())
						{
							case "00":
								button00_.State = StateType.Insensitive;
								break;
							case "10":
								button10_.State = StateType.Insensitive;
								break;
							case "20":
								button20_.State = StateType.Insensitive;
								break;
							case "30":
								button30_.State = StateType.Insensitive;
								break;
							case "40":
								button40_.State = StateType.Insensitive;
								break;
							case "50":
								button50_.State = StateType.Insensitive;
								break;
							case "60": 
								button60_.State = StateType.Insensitive;
								break; // Ponedjeljak - prijepodne
							case "70":
								button70_.State = StateType.Insensitive;
								break;
							case "80":
								button80_.State = StateType.Insensitive;
								break;
							case "90":
								button90_.State = StateType.Insensitive;
								break;
							case "100":
								button100_.State = StateType.Insensitive;
								break;
							case "110":
								button110_.State = StateType.Insensitive;
								break;
							case "120":
								button120_.State = StateType.Insensitive;
								break;
							case "130":
								button130_.State = StateType.Insensitive;
								break;	
							case "140":
								button140_.State = StateType.Insensitive;
								break; // Ponedjeljak - posljepodne
						
							case "01":
								button01_.State = StateType.Insensitive;
								break;
							case "11":
								button11_.State = StateType.Insensitive;
								break;
							case "21":
								button21_.State = StateType.Insensitive;
								break;
							case "31":
								button31_.State = StateType.Insensitive;
								break;
							case "41":
								button41_.State = StateType.Insensitive;
								break;
							case "51":
								button51_.State = StateType.Insensitive;
								break;
							case "61":
								button61_.State = StateType.Insensitive;
								break; // Utorak - prijepodne
							case "71":
								button71_.State = StateType.Insensitive;
								break;
							case "81":
								button81_.State = StateType.Insensitive;
								break;
							case "91":
								button91_.State = StateType.Insensitive;
								break;
							case "101":
								button101_.State = StateType.Insensitive;
								break;
							case "111":
								button111_.State = StateType.Insensitive;
								break;
							case "121":
								button121_.State = StateType.Insensitive;
								break;
							case "131":
								button131_.State = StateType.Insensitive;
								break;
							case "141":
								button141_.State = StateType.Insensitive;
								break; // Utorak - posljepodne

							case "02":
								button02_.State = StateType.Insensitive;
								break;
							case "12":
								button12_.State = StateType.Insensitive;
								break;
							case "22":
								button22_.State = StateType.Insensitive;
								break;
							case "32":
								button32_.State = StateType.Insensitive;
								break;
							case "42":
								button42_.State = StateType.Insensitive;
								break;
							case "52":
								button52_.State = StateType.Insensitive;
								break;
							case "62":
								button62_.State = StateType.Insensitive;
								break; // Srijeda - prijepodne
							case "72":
								button72_.State = StateType.Insensitive;
								break;
							case "82":
								button82_.State = StateType.Insensitive;
								break;
							case "92":
								button92_.State = StateType.Insensitive;
								break;
							case "102":
								button102_.State = StateType.Insensitive;
								break;
							case "112":
								button112_.State = StateType.Insensitive;
								break;
							case "122":
								button122_.State = StateType.Insensitive;
								break;
							case "132":
								button132_.State = StateType.Insensitive;
								break;
							case "142":
								button142_.State = StateType.Insensitive;
								break; // Srijeda - posljepodne

							case "03":
								button03_.State = StateType.Insensitive;
								break;
							case "13":
								button13_.State = StateType.Insensitive;
								break;
							case "23":
								button23_.State = StateType.Insensitive;
								break;
							case "33":
								button33_.State = StateType.Insensitive;
								break;
							case "43":
								button43_.State = StateType.Insensitive;
								break;
							case "53":
								button53_.State = StateType.Insensitive;
								break;
							case "63":
								button63_.State = StateType.Insensitive;
								break; // Četvrtak - prijepodne
							case "73":
								button73_.State = StateType.Insensitive;
								break;
							case "83":
								button83_.State = StateType.Insensitive;
								break;
							case "93":
								button93_.State = StateType.Insensitive;
								break;
							case "103":
								button103_.State = StateType.Insensitive;
								break;
							case "113":
								button113_.State = StateType.Insensitive;
								break;
							case "123":
								button123_.State = StateType.Insensitive;
								break;
							case "133":
								button133_.State = StateType.Insensitive;
								break;
							case "143":
								button143_.State = StateType.Insensitive;
								break; // Četvrtak - posljepodne

							case "04":
								button04_.State = StateType.Insensitive;
								break;
							case "14":
								button14_.State = StateType.Insensitive;
								break;
							case "24":
								button24_.State = StateType.Insensitive;
								break;
							case "34":
								button34_.State = StateType.Insensitive;
								break;
							case "44":
								button44_.State = StateType.Insensitive;
								break;
							case "54":
								button54_.State = StateType.Insensitive;
								break;
							case "64":
								button64_.State = StateType.Insensitive;
								break; // Petak - prijepodne
							case "74":
								button74_.State = StateType.Insensitive;
								break;
							case "84":
								button84_.State = StateType.Insensitive;
								break;
							case "94":
								button94_.State = StateType.Insensitive;
								break;
							case "104":
								button104_.State = StateType.Insensitive;
								break;
							case "114":
								button114_.State = StateType.Insensitive;
								break;
							case "124":
								button124_.State = StateType.Insensitive;
								break;
							case "134":
								button134_.State = StateType.Insensitive;
								break;
							case "144":
								button144_.State = StateType.Insensitive;
								break; // Petak - posljepodne
						}
					}	
				}
			}
		} // Obavlja provjeru jeli predavac zauzet ili uciona na svim buttonima

		protected void OnButtonOdustaniClicked(object sender, EventArgs e)
		{
			this.Destroy();
		}

		protected void OnButtonSpremiClicked(object sender, EventArgs e)
		{
			string Predavaci_IDucionice = "";
			string Ucionice_IDpredavaci = "";
			for (int i = 0; i < 15; ++i) 
			{
				for (int j = 0; j < 5; ++j) 
				{ 
					if (pomocno_polje[i,j] == true)
					{
						_predavac.raspored_pamti_IDuciona[i, j] = _ucionica.ID;
						_ucionica.raspored_pamti_IDpredavac[i,j] = _predavac.ID;
					}
				
					Predavaci_IDucionice = Predavaci_IDucionice + _predavac.raspored_pamti_IDuciona[i, j] + ',';
					Ucionice_IDpredavaci = Ucionice_IDpredavaci + _ucionica.raspored_pamti_IDpredavac[i, j] + ','; // Punimo novi string s nekim promjenjenim IDovima za update dvodimenzionalnog polja
				}
			}
			DBPredavac.Update_redak(Predavaci_IDucionice, _predavac.OIB); // Update redak
			DBUcionica.Update_redak(Ucionice_IDpredavaci, _ucionica.naziv); 
			this.Destroy();
		}
	}
}

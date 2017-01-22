using System;
using Gtk;

namespace Raspored
{
	public partial class PregledajTermineWindow : Gtk.Window
	{
		int[,] pomocno_polje = new int[,] { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
		Predavac temp;

		public PregledajTermineWindow() : base(Gtk.WindowType.Toplevel)
		{
			this.Build();
			int br = 0;
			foreach (var a in Skola.ucionice_lista) {
				combobox_ucionice.InsertText(++br, a.naziv);
			}
		} // Konstruktor

		protected void OnButtonEntered(object sender, EventArgs e)
		{
			if (combobox_ucionice.ActiveText!=null)
			{
				var butt = (Button)sender;

				foreach (var a in Skola.ucionice_lista)
				{
					if (combobox_ucionice.ActiveText == a.naziv)
					{
						pomocno_polje = a.raspored_pamti_IDpredavac;
						label_opis.Text = a.komentar;
					}
				}


				switch (butt.Name)
				{
					case "button00_":
						if (pomocno_polje[0, 0] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[0, 0]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button10_":
						if (pomocno_polje[1, 0] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[1, 0]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button20_":
						if (pomocno_polje[2, 0] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[2, 0]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else 
						{ 
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button30_":
						if (pomocno_polje[3, 0] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[3, 0]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button40_":
						if (pomocno_polje[4, 0] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[4, 0]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button50_":
						if (pomocno_polje[5, 0] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[5, 0]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button60_":
						if (pomocno_polje[6, 0] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[6, 0]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break; // Ponedjeljak - prijepodne
					case "button70_":
						if (pomocno_polje[7, 0] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[7, 0]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button80_":
						if (pomocno_polje[8, 0] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[8, 0]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button90_":
						if (pomocno_polje[9, 0] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[9, 0]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button100_":
						if (pomocno_polje[10, 0] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[10, 0]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button110_":
						if (pomocno_polje[11, 0] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[11, 0]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button120_":
						if (pomocno_polje[12, 0] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[12, 0]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button130_":
						if (pomocno_polje[13, 0] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[13, 0]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button140_":
						if (pomocno_polje[14, 0] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[14, 0]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break; // Ponedjeljak - posljepodne

					case "button01_":
						if (pomocno_polje[0, 1] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[0, 1]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button11_":
						if (pomocno_polje[1, 1] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[1, 1]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button21_":
						if (pomocno_polje[2, 1] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[2, 1]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button31_":
						if (pomocno_polje[3, 1] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[3, 1]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button41_":
						if (pomocno_polje[4, 1] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[4, 1]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button51_":
						if (pomocno_polje[5, 1] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[5, 1]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button61_":
						if (pomocno_polje[6, 1] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[6, 1]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break; // Utorak - prijepodne
					case "button71_":
						if (pomocno_polje[7, 1] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[7, 1]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button81_":
						if (pomocno_polje[8, 1] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[8, 1]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button91_":
						if (pomocno_polje[9, 1] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[9, 1]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button101_":
						if (pomocno_polje[10, 1] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[10, 1]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button111_":
						if (pomocno_polje[11, 1] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[11, 1]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button121_":
						if (pomocno_polje[12, 1] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[12, 1]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button131_":
						if (pomocno_polje[13, 1] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[13, 1]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button141_":
						if (pomocno_polje[14, 1] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[14, 1]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break; // Utorak - posljepodne

					case "button02_":
						if (pomocno_polje[0, 2] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[0, 2]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button12_":
						if (pomocno_polje[1, 2] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[1, 2]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button22_":
						if (pomocno_polje[2, 2] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[2, 2]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button32_":
						if (pomocno_polje[3, 2] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[3, 2]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button42_":
						if (pomocno_polje[4, 2] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[4, 2]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button52_":
						if (pomocno_polje[5, 2] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[5, 2]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button62_":
						if (pomocno_polje[6, 2] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[6, 2]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break; // Srijeda - prijepodne
					case "button72_":
						if (pomocno_polje[7, 2] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[7, 2]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button82_":
						if (pomocno_polje[8, 2] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[8, 2]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button92_":
						if (pomocno_polje[9, 2] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[9, 2]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button102_":
						if (pomocno_polje[10, 2] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[10, 2]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button112_":
						if (pomocno_polje[11, 2] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[11, 2]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button122_":
						if (pomocno_polje[12, 2] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[12, 2]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button132_":
						if (pomocno_polje[13, 2] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[12, 2]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button142_":
						if (pomocno_polje[14, 2] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[14, 2]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break; // Srijeda - posljepodne

					case "button03_":
						if (pomocno_polje[0, 3] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[0, 3]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button13_":
						if (pomocno_polje[1, 3] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[1, 3]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button23_":
						if (pomocno_polje[2, 3] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[2, 3]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button33_":
						if (pomocno_polje[3, 3] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[3, 3]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button43_":
						if (pomocno_polje[4, 3] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[4, 3]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button53_":
						if (pomocno_polje[5, 3] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[5, 3]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button63_":
						if (pomocno_polje[6, 3] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[6,3]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break; // Četvrtak - prijepodne
					case "button73_":
						if (pomocno_polje[7,3] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[7,3]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button83_":
						if (pomocno_polje[8,3] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[8,3]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button93_":
						if (pomocno_polje[9,3] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[9,3]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button103_":
						if (pomocno_polje[10,3] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[10,3]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button113_":
						if (pomocno_polje[11,3] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[11,3]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button123_":
						if (pomocno_polje[12,3] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[12,3]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button133_":
						if (pomocno_polje[13,3] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[13,3]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button143_":
						if (pomocno_polje[14,3] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[14,3]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break; // Četvrtak - posljepodne

					case "button04_":
						if (pomocno_polje[0,4] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[0,4]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button14_":
						if (pomocno_polje[1,4] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[1,4]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button24_":
						if (pomocno_polje[2, 4] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[2, 4]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button34_":
						if (pomocno_polje[3,4] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[3,4]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button44_":
						if (pomocno_polje[4,4] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[4,4]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button54_":
						if (pomocno_polje[5,4] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[5,4]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button64_":
						if (pomocno_polje[6,4] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[6,4]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break; // Petak - prijepodne
					case "button74_":
						if (pomocno_polje[7,4] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[7,4]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button84_":
						if (pomocno_polje[8,4] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[8,4]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button94_":
						if (pomocno_polje[9,4] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[9,4]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button104_":
						if (pomocno_polje[10, 4] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[10, 4]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button114_":
						if (pomocno_polje[11, 4] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[11, 4]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button124_":
						if (pomocno_polje[12, 4] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[12, 4]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button134_":
						if (pomocno_polje[13, 4] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[13, 4]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break;
					case "button144_":
						if (pomocno_polje[14, 4] != 0)
						{
							temp = Skola.vratiPredavaca_ID(pomocno_polje[14, 4]);
							label_ime.Text = temp.ime;
							label_prezime.Text = temp.prezime;
							label_OIB.Text = temp.OIB;
							label_status.Text = "Zauzeto";
						}
						else
						{
							label_ime.Text = "";
							label_prezime.Text = "";
							label_OIB.Text = "";
							label_status.Text = "Slobodno";
						}
						break; // Petak - posljepodne
				}
			}
		}

		protected void OnButtonIzlazClicked(object sender, EventArgs e)
		{
			this.Destroy();
		}
	}
}

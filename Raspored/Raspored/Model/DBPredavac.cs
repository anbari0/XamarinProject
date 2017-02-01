using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;

namespace Raspored
{
	public static class DBPredavac
	{
		static DBPredavac() 
		{
			// Instanciranje SQL komande
			SqliteCommand com = DB.con.CreateCommand();
			// DROP TABLE IF EXISTS Predavac;
			com.CommandText = @"
				
				CREATE TABLE IF NOT EXISTS Predavac(
					ID integer primary key autoincrement,
					ime nvarchar(32),
					prezime nvarchar(32),
					adresa nvarchar(32),
					OIB nvarchar(11) NOT NULL,
					polje_IDucionice nvarchar(250),
					CONSTRAINT OIB_unique UNIQUE(OIB))";

			// izvršavanje SQL naredbe koja ne vraća rezultate (nije upit)
			com.ExecuteNonQuery();
			// otpuštanje resursa
			com.Dispose();
		}

		public static List<Predavac> DohvatiSve_Predavace() {
			var lista = new List<Predavac>();

			SqliteCommand c = DB.con.CreateCommand();

			c.CommandText = String.Format(@"SELECT ID, ime, prezime, adresa, OIB, polje_IDucionice FROM Predavac;");

			SqliteDataReader reader = c.ExecuteReader();

			while (reader.Read()) 
			{
				Predavac temp = new Predavac(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
				// Dodati za unos u polje
				lista.Add(temp);
			}

			c.Dispose();

			return lista;
		}

		public static Predavac Dohvati_Predavaca(string OIB)
		{
			SqliteCommand c = DB.con.CreateCommand();

			c.CommandText = String.Format(@"SELECT ID, ime, prezime, adresa, OIB, polje_IDucionice FROM Predavac WHERE OIB = {0};", OIB);

			SqliteDataReader reader = c.ExecuteReader();

			while (reader.Read()) {
				Predavac temp = new Predavac(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
				c.Dispose();
				return temp;
			}
			c.Dispose();
			return null;
		} // Dohvaćamo iz baze predavaca po argumentima IME, PREZIME, OIB

		public static void Update_redak(string IDucionica, string OIB)
		{
			SqliteCommand c = DB.con.CreateCommand();

			c.CommandText = String.Format(@"UPDATE Predavac SET polje_IDucionice = '{0}' WHERE OIB = {1}", IDucionica, OIB);

			c.ExecuteNonQuery();
			c.Dispose();
		} // Nadograđuje u redku dvodimenzionalno polje

		public static void Izbrisi_redak(string OIB)
		{
			SqliteCommand c = DB.con.CreateCommand();

			c.CommandText = String.Format(@"DELETE FROM Predavac WHERE OIB = {0};", OIB);

			c.ExecuteNonQuery();
			c.Dispose();
		} // DOVRSITI

		public static void DodajSve(List<Predavac> predavac) 
		{
			foreach (var a in predavac) 
			{
				Dodaj(a);
			}
		}

		public static void Dodaj(Predavac a) 
		{
			SqliteCommand c = DB.con.CreateCommand();

			c.CommandText = String.Format(@"INSERT INTO Predavac (ime, prezime, adresa, OIB, polje_IDucionice) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", a.ime, a.prezime, a.adresa, a.OIB, a.polje_IDucionice);

			c.ExecuteNonQuery();
			c.Dispose();
		} // Ubacujemo u bazu Predavaca
	}
}

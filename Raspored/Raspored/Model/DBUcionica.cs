using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;

namespace Raspored
{
	public static class DBUcionica
	{
		static DBUcionica()
		{
			// Instanciranje SQL komande
			SqliteCommand com = DB.con.CreateCommand();
			// DROP TABLE IF EXISTS Ucionica;
			com.CommandText = @"
				 
				CREATE TABLE IF NOT EXISTS Ucionica(
					ID integer primary key autoincrement,
					naziv nvarchar(32),
					kapacitet nvarchar(32),
					komentar nvarchar(32),
					polje_IDpredavaca nvarchar(200),
					CONSTRAINT NAZIV_unique UNIQUE(naziv))";

			// izvršavanje SQL naredbe koja ne vraća rezultate (nije upit)
			com.ExecuteNonQuery();
			// otpuštanje resursa
			com.Dispose();
		}

		public static List<Ucionica> DohvatiSve_Ucionice()
		{
			var lista = new List<Ucionica>();

			SqliteCommand c = DB.con.CreateCommand();

			c.CommandText = String.Format(@"SELECT ID, naziv, kapacitet, komentar, polje_IDpredavaca FROM Ucionica;");

			SqliteDataReader reader = c.ExecuteReader();

			while (reader.Read())
			{
				Ucionica temp = new Ucionica(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
				// Dodati za unos u polje
				lista.Add(temp);
			}

			c.Dispose();

			return lista;
		}

		public static Ucionica Dohvati_Ucionicu(string naziv)
		{
			SqliteCommand c = DB.con.CreateCommand();

			c.CommandText = String.Format(@"SELECT ID, naziv, kapacitet, komentar, polje_IDpredavaca FROM Ucionica WHERE naziv = '{0}';", naziv);

			SqliteDataReader reader = c.ExecuteReader();

			while (reader.Read())
			{
				Ucionica temp = new Ucionica(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
				c.Dispose();
				return temp;
			}
			c.Dispose();
			return null;
		}

		public static void Update_redak(string IDpredavaci, string naziv)
		{
			SqliteCommand c = DB.con.CreateCommand();

			c.CommandText = String.Format(@"UPDATE Ucionica SET polje_IDpredavaca = '{0}' WHERE naziv = '{1}';", IDpredavaci, naziv);

			c.ExecuteNonQuery();
			c.Dispose();
		} // Nadograđuje u redku dvodimenzionalno polje (koristimo ga kod zauzimanja termina)

		public static void Izbrisi_redak(string naziv)
		{
			SqliteCommand c = DB.con.CreateCommand();

			c.CommandText = String.Format(@"DELETE FROM Ucionica WHERE naziv = '{0}';", naziv);

			c.ExecuteNonQuery();
			c.Dispose();
		}

		public static void DodajSve(List<Ucionica> ucionica)
		{
			foreach (var a in ucionica)
			{
				Dodaj(a);
			}
		}

		public static void Dodaj(Ucionica a)
		{
			SqliteCommand c = DB.con.CreateCommand();

			c.CommandText = String.Format(@"INSERT INTO Ucionica (naziv, kapacitet, komentar, polje_IDpredavaca) VALUES ('{0}', '{1}', '{2}', '{3}')", a.naziv, a.kapacitet, a.komentar, a.polje_IDpredavaci);

			c.ExecuteNonQuery();
			c.Dispose();
		}
	}
}
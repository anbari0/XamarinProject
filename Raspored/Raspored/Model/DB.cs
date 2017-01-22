using System;
using Mono.Data.Sqlite;

namespace Raspored
{
	public static class DB
	{
		private static string connectionString = "URI=file:BazaRaspored.db3,version=3";

		internal static SqliteConnection con = new SqliteConnection(connectionString);

		internal static void OtvoriKonekciju() 
		{
			con.Open();		
		}
		internal static void ZatvoriKonekciju()
		{
			con.Close();
		}
	}
}
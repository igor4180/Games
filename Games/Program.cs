using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamesDll;


namespace Games
{
	internal class Program
	{
		static void Main(string[] args)
		{
			using (GamesContext.GamesContext gc = new GamesContext.GamesContext(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString))
			{
				Games game1 = new Games();
				game1.Name = "Doom";
				game1.Creator = "idtech";
				game1.Genre = "action";
				game1.Date = DateTime.Now;

				game2.Name = "Heroes of Might and Magic";
				game2.Creator = "3DD";
				game2.Genre = "strategy";
				game2.Date = DateTime.Now;

				gc.gamesSet.Add(game1);
				gc.gamesSet.Add(game2);

				gc.SaveChanges();
			}
		}
	}
}

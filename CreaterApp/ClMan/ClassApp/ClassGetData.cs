using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClMan.ADOApp;

namespace ClMan.ClassApp
{
    public class ClassGetData
    {
        
        public static List<Games> GameListDonHaw()
        {
            List<Games> gamesListReturn = new List<Games>();
            List<Games> gamesList = new List<Games>();
            var CorrLib = ClassCorrUser.CorrUser.Librarys.First(); 
            var ListLab = new List<LibrarysGames>(App.Connection.LibrarysGames.Where(z=>z.Library_id == CorrLib.id_library).ToList());
            foreach (var index in ListLab)
            {
                gamesList.Add(index.Games);
            }
            List<Games> AllGames = new List<Games>(App.Connection.Games.ToList());
            gamesListReturn = AllGames.ToList();
            foreach (var Index in AllGames.ToList())
            {
                foreach (var Game in gamesList.ToList())
                {
                    if (Index == Game)
                    {
                        gamesListReturn.Remove(Game);
                    }
                }
            }
            return gamesListReturn;
        }
    }
}

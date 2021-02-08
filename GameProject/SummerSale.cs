using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SummerSale:ICampaign
    {
        public void AddGame(Game game)
        {
            Console.WriteLine("Yaz İndirimi" + game.GameName + "Oyuna Eklendi");
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine(game.GameName + " Oyunun Fiyatı Yaz İndirimi Bitmesi Sebebiyle Güncellendi: ", game.GamePrice - 10);
        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine("Yaz İndirimi " + game.GameName + "Oyunundan Silindi");
        }
    }
}

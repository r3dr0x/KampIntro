using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + "Oyunu Eklendi" + "Fiyatı :"  + game.GamePrice);
        }

        public void Sell(Game game)
        {
            Console.WriteLine(game.GameName + "Oyunu Satıldı");
        }
    }
}

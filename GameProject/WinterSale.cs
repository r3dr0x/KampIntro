using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class WinterSale:ICampaign
    {
        public void AddGame(Game game)
        {
            Console.WriteLine("Kış İndirimi" + game.GameName + "Oyununa Eklendi");
        }

        public void UpdateGame(Game game)
        {
            int new_price = game.GamePrice - 10;
            Console.WriteLine("Kış İndirimi" + game.GameName + "Oyununda Güncellendi .  Yeni Fİyatı : " + new_price);
        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine("Kış İndirimi" + game.GameName + "Oyunundan Silindi");
        }
    }
}

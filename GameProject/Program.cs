using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer() {Id = 1, BirthYear = 1985, FirstName = "ENGİN", LastName = "DEMİROĞ", IdentityNumber = 12345});


            Game game1 = new Game()
            {
                GameName = "FIFA 21",
                GamePrice = 35
            };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            ICampaign winterSale = new WinterSale();
            winterSale.AddGame(game1);

            GameManager gameManager1 = new GameManager();
            gameManager1.Sell(game1);

        }
    }
}

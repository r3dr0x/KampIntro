using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaign
    {
        void AddGame(Game game);
        void UpdateGame(Game game);
        void DeleteGame(Game game);
    }
}

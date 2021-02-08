﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace GameProject
{
    class GamerManager:IGamerService
    {
        
        IUserValidationService _userValidationService;


        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }



        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt Oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız . Kayıt başarısız");
            }

            
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }
    }
}

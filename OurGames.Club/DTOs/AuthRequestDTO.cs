using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OurGames.Club.DTOs
{
    public class AuthRequestDTO
    {

        public string username { get; set; }

        public string password { get; set; }

        public bool remember { get; set; }

    }
}
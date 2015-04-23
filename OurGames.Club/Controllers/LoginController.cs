using OurGames.Club.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;

namespace OurGames.Club.Controllers
{
    public class LoginController : ApiController
    {

        // GET: api/Login (is authenticated?)
        public LoginResutDTO Get()
        {
            if (User.Identity.IsAuthenticated)
            {
                //using (var context = new AnimesClubContext())
                //{
                //    var user = context.Users.Find(long.Parse(User.Identity.Name));

                //    return new LoginSuccessDTO
                //    {
                //        username = user.username,
                //        email = user.email,
                //        picture = user.picture
                //    };
                //}
                return new LoginResutDTO
                {
                    username = "xereta",
                    email = "xereta@ourgames.club",
                    picture = "https://fbcdn-profile-a.akamaihd.net/hprofile-ak-xat1/v/t1.0-1/p50x50/1794800_826051180748416_3700381980564345467_n.jpg?oh=557879eb569b158fc62266b04706d84f&oe=559C92BE&__gda__=1440244437_7c1515321764e96fd360b7b6798cb631"
                };
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.Forbidden);
            }
        }

        // POST: api/Login
        public LoginResutDTO Post(AuthRequestDTO data)
        {
            //using (var context = new AnimesClubContext())
            //{
            //    var passwordHash = PasswordService.GetHash(data.password);
            //    var user = context.Users.FirstOrDefault(x => (x.username.ToLower() == data.username.ToLower() || x.email.ToLower() == data.username.ToLower()) && x.password == passwordHash);
            //    if (user != null)
            //    {
            //        FormsAuthentication.SetAuthCookie(user.id.ToString(), data.remember);

            //        return new LoginSuccessDTO
            //        {
            //            username = user.username,
            //            email = user.email,
            //            picture = user.picture
            //        };
            //    }
            //    else
            //    {
            //        throw new HttpResponseException(HttpStatusCode.Forbidden);
            //    }
            //}

            return new LoginResutDTO
            {
                username = "xereta",
                email = "xereta@ourgames.club",
                picture = "https://fbcdn-profile-a.akamaihd.net/hprofile-ak-xat1/v/t1.0-1/p50x50/1794800_826051180748416_3700381980564345467_n.jpg?oh=557879eb569b158fc62266b04706d84f&oe=559C92BE&__gda__=1440244437_7c1515321764e96fd360b7b6798cb631"
            };
        }

        // DELETE: api/Login
        public void Delete()
        {
            FormsAuthentication.SignOut();
        }

    }
}

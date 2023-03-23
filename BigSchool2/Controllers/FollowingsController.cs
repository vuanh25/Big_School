using BigSchool2.DTO;
using BigSchool2.Models;
using Microsoft.AspNet.Identity;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace BigSchool2.Controllers
{
    public class FollowingsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }

       /* [HttpPost]
        public IHttpActionResult FLow(string followingDto)
        {
            var userId = User.Identity.GetUserId();
            //if (d.Followings.Any(a => a.FollowerID == userId && a.FolloweeID == followingDto))
            //{
            //    return BadRequest("Da theo doi!");
            //} 

            ApplicationDbContext _dbContext = new ApplicationDbContext();
            var following = new Following
            {
                FollowerID = userId,
                FolloweeID = followingDto
            };

            _dbContext.Followings.Add(following);
            _dbContext.SaveChanges();

            return Ok();
        }
*/
        /* [HttpPost]
         public IHttpActionResult Follow(FollowingDto followingDto)
         {
             var userId = User.Identity.GetUserId();
             if (_dbContext.)
             {

             }
         }*/
        // GET: Followings
        public ActionResult Index()
        {
            return View();
        }


    }
}
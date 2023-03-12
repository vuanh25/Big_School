﻿using BigSchool.Models;
using BigSchool.Models.EF;
using BigSchool.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Cources
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        // Xác thực đăng nhập chỉ cho phép người dùng có tk đăng nhậpO
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };


            return View(viewModel);
        }

        //[Authorize]
        //[HttpPost]
        //public ActionResult Create(CourseViewModel viewModel)
        //{
        //    var course = new Course
        //    {
        //        LecturerId = User.Identity.GetUserId(),
        //        DateTime = viewModel.GetDateTime(),
        //        CategoryId = viewModel.Category,
        //        Place = viewModel.Place
        //    };
        //    _dbContext.Courses.Add(course);
        //    _dbContext.SaveChanges();

        //    return RedirectToAction("Index", "Home");
        //}

    }
}
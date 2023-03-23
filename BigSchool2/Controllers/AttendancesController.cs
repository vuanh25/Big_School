using BigSchool2.DTO;
using BigSchool2.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BigSchool2.Controllers
{
    public class AttendancesController : ApiController
    {
        private readonly ApplicationDbContext d = new ApplicationDbContext();

        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            if (d.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == attendanceDto.CourseId))
            {
                return BadRequest("Khoa hoc da follow!");
            }


            ApplicationDbContext _dbContext = new ApplicationDbContext();
            var attendance = new Attendance
            {
                CourseId = attendanceDto.CourseId,
                AttendeeId = userId
            };

            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}

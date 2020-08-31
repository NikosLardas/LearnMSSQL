using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnMSSQL.Models;
using Microsoft.AspNet.Identity;
using LearnMSSQL.ViewModels;

namespace LearnMSSQL.Controllers
{
    public class MyResultsController : Controller
    {
        //Connection with database

        private ApplicationDbContext _context;

        public MyResultsController()
        {
            _context = new ApplicationDbContext();
        }

        //Disposal of DbContext, which is a disposable object

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
           //Get Id of the current logged in user
           var CurrentUserId = User.Identity.GetUserId();

           var ViewModel = new ResultsViewModel();


           //Search the database to find if the currently logged in user has taken Test 1
           var TestRecord = _context.MyResults.SingleOrDefault(c => c.TestName == "Test 1" && c.UserID == CurrentUserId);

           //If not, assign the value 1234 to Grade1. If yes, get datetime and grade
           if (TestRecord == null)
            {
                ViewModel.Grade1 = 1234;
            }
           else
            {
                ViewModel.Grade1 = TestRecord.Grade;
                ViewModel.Time1 = TestRecord.Time;
            }

            //Same prodecure as before for Test 2
            TestRecord = _context.MyResults.SingleOrDefault(c => c.TestName == "Test 2" && c.UserID == CurrentUserId);

            if (TestRecord == null)
            {
                ViewModel.Grade2 = 1234;
            }
            else
            {
                ViewModel.Grade2 = TestRecord.Grade;
                ViewModel.Time2 = TestRecord.Time;
            }

            //Same prodecure as before for Test 3
            TestRecord = _context.MyResults.SingleOrDefault(c => c.TestName == "Test 3" && c.UserID == CurrentUserId);

            if (TestRecord == null)
            {
                ViewModel.Grade3 = 1234;
            }
            else
            {
                ViewModel.Grade3 = TestRecord.Grade;
                ViewModel.Time3 = TestRecord.Time;
            }

            //Same prodecure as before for Test 4
            TestRecord = _context.MyResults.SingleOrDefault(c => c.TestName == "Test 4" && c.UserID == CurrentUserId);

            if (TestRecord == null)
            {
                ViewModel.Grade4 = 1234;
            }
            else
            {
                ViewModel.Grade4 = TestRecord.Grade;
                ViewModel.Time4 = TestRecord.Time;
            }

            //Return the view together with the results stored in the viewmodel
            
            return View(ViewModel);
           
        }
    }
}
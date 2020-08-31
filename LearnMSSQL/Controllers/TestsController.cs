using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnMSSQL.ViewModels;
using Microsoft.AspNet.Identity;
using LearnMSSQL.Models;



namespace LearnMSSQL.Controllers
{
    public class TestsController : Controller
    {
        //Connection with database

        private ApplicationDbContext _context;

        public TestsController()
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
            return View();
        }
        
        public ActionResult Test1()
        {
            return View();
        }

        public ActionResult Test2()
        {
            return View();
        }

        public ActionResult Test3()
        {
            return View();
        }

        public ActionResult Test4()
        {
                return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ResultsCalculation(ResultsViewModel viewModel)
        {
              // Validate user has replied to all questions in the Test.
              // If not, return the same page with the answers he provided.
            

            if (!ModelState.IsValid)
            {

                if (viewModel.TestTaken == "Test 1")
                {
                    return View("Test1", viewModel);
                }
                else if (viewModel.TestTaken == "Test 2")
                {
                    return View("Test2", viewModel);
                }
                    
                else if (viewModel.TestTaken == "Test 3")
                {
                    return View("Test3", viewModel);
                }
                else if (viewModel.TestTaken == "Test 4")
                {
                    return View("Test4", viewModel);
                }

            }

            //Calculate the Grade for the Test that was submitted

            var FinalGrade = 0;

            if (viewModel.Answer1 == true)
                FinalGrade += 10;
            if (viewModel.Answer2 == true)
                FinalGrade += 10;
            if (viewModel.Answer3 == true)
                FinalGrade += 10;
            if (viewModel.Answer4 == true)
                FinalGrade += 10;
            if (viewModel.Answer5 == true)
                FinalGrade += 10;
            if (viewModel.Answer6 == true)
                FinalGrade += 10;
            if (viewModel.Answer7 == true)
                FinalGrade += 10;
            if (viewModel.Answer8 == true)
                FinalGrade += 10;
            if (viewModel.Answer9 == true)
                FinalGrade += 10;
            if (viewModel.Answer10 == true)
                FinalGrade += 10;


            //Get Id of the current logged in user
            var CurrentUserId = User.Identity.GetUserId();

            //The following logic is applied for all 4 Tests

            //Check which Test the user submitted
            if (viewModel.TestTaken == "Test 1")
            {
                //Search the database to find if the currently logged in user has already submitted this Test in the past
                var TestRecord = _context.MyResults.SingleOrDefault(c => c.TestName == "Test 1" && c.UserID == CurrentUserId);

                //If not, created and add a new record in the table MyResults,
                //including the current Datetime and the calculated Grade
                if (TestRecord == null)
                {
                    var NewTestRecord = new MyResults
                    {
                        UserID = CurrentUserId,
                        TestName = "Test 1",
                        TestSubject = "Microsoft SQL Server Basics",
                        Difficulty = "Beginner",
                        Time = DateTime.Now,
                        Grade = FinalGrade
                    };

                    _context.MyResults.Add(NewTestRecord);

                }
                //If the user has already submitted this test in the past, 
                //update the database record with the current Datetime and the new Grade
                else
                {

                    TestRecord.Time = DateTime.Now;
                    TestRecord.Grade = FinalGrade;

                }

            }
            else if (viewModel.TestTaken == "Test 2")
            {

                var TestRecord = _context.MyResults.SingleOrDefault(c => c.TestName == "Test 2" && c.UserID == CurrentUserId);

                if (TestRecord == null)
                {
                    var NewTestRecord = new MyResults
                    {
                        UserID = CurrentUserId,
                        TestName = "Test 2",
                        TestSubject = "Microsoft SQL Server Advanced",
                        Difficulty = "Student",
                        Time = DateTime.Now,
                        Grade = FinalGrade
                    };

                    _context.MyResults.Add(NewTestRecord);

                }
                else
                {

                    TestRecord.Time = DateTime.Now;
                    TestRecord.Grade = FinalGrade;

                }

            }
            else if (viewModel.TestTaken == "Test 3")
            {

                var TestRecord = _context.MyResults.SingleOrDefault(c => c.TestName == "Test 3" && c.UserID == CurrentUserId);

                if (TestRecord == null)
                {
                    var NewTestRecord = new MyResults
                    {
                        UserID = CurrentUserId,
                        TestName = "Test 3",
                        TestSubject = "Microsoft SQL Server Master",
                        Difficulty = "Master",
                        Time = DateTime.Now,
                        Grade = FinalGrade
                    };

                    _context.MyResults.Add(NewTestRecord);

                }
                else
                {

                    TestRecord.Time = DateTime.Now;
                    TestRecord.Grade = FinalGrade;

                }

            }
            else if (viewModel.TestTaken == "Test 4")
            {

                var TestRecord = _context.MyResults.SingleOrDefault(c => c.TestName == "Test 4" && c.UserID == CurrentUserId);

                if (TestRecord == null)
                {
                    var NewTestRecord = new MyResults
                    {
                        UserID = CurrentUserId,
                        TestName = "Test 4",
                        TestSubject = "Microsoft SQL Server Professor",
                        Difficulty = "Professor",
                        Time = DateTime.Now,
                        Grade = FinalGrade
                    };

                    _context.MyResults.Add(NewTestRecord);

                }
                else
                {

                    TestRecord.Time = DateTime.Now;
                    TestRecord.Grade = FinalGrade;

                }

            }

            //Save changes to the database
            _context.SaveChanges();

            //Redirect to MyResults page
            return RedirectToAction("Index", "MyResults");


        }

    }
}
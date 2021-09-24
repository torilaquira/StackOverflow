using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StackOverflowLab.Models;

namespace StackOverflowLab.Controllers
{
    public class AnswersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListAnswers(int questID)
        {
            QuestionsAnswers qa = DAL.GetAllForQuestions(questID);
            return View(qa);



        }

        public IActionResult editanswer(int ansid)
        {
            answers emp = DAL.GetAnswers(ansid);
            return View(emp);
        }

        public IActionResult AddAnswer (answers ans)
        {
            DAL.AddAnswer(ans);
            return RedirectToAction("Index");
            
        }

        public IActionResult saveanswer(answers ans)
        {
            DAL.EditAnswer(ans);
            //                /Answers/ListAnswers?questID=1
            return Redirect($"/Answers/ListAnswers?questID={ans.questionId}");
        }
    }
}

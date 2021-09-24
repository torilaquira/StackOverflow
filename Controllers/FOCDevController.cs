using Microsoft.AspNetCore.Mvc;
using StackOverflowLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflowLab.Controllers
{
    public class FOCDevController : Controller
    {
		public IActionResult Index()
		{
			List<Questions> ques = DAL.AllQuestions();
			return View(ques);
		}

		public IActionResult Questions (string ques)
        {
			return Content(ques);
        }
		public IActionResult editquestion (int quesid)
		{
			Questions ques = DAL.GetQuestions(quesid);
			return View(ques);
		}

		public IActionResult savequestion(Questions ques)
		{
			DAL.EditQuestion(ques);
			
			return Redirect($"/focdev/index?quesID={ques.id}");
		}



	}
}

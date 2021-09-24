using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace StackOverflowLab.Models
{
	public class QuestionsAnswers
	{
		public Questions ques { get; set; }
		public List<answers> ans { get; set; }
	}
}
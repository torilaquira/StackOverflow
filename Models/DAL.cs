using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;

namespace StackOverflowLab.Models
{
    public class DAL
    {
        public static string CurrentUser = null;
        public static MySqlConnection DB = new MySqlConnection("Server=localhost;Database=foc;Uid=root;Password=abc123");

        //view all questions
        public static List<Questions> AllQuestions()
        {

            return DB.GetAll<Questions>().ToList();
        }

        

        //update or edit question
        public static void EditQuestion(Questions ques)
        {
            ques.username = DAL.CurrentUser;
            DB.Update(ques);
        }

        //view all answers
        public static List<answers> Answers()
        {
            return DB.GetAll<answers>().ToList();
        }

      
        

        //edit or update an answer
        public static void EditAnswer(answers ans)
        {
            ans.username =DAL.CurrentUser;
            DB.Update(ans);
        }

        
        
        // Read the details for an answer by id
        public static answers GetAnswers(int id)
        {
            return DB.Get<answers>(id);
        }

        public static Questions GetQuestions(int id)
        {
            return DB.Get<Questions>(id);
        }

        public static void AddQuestionAndAnswers(Questions ques, answers ans)
        {
            ques.username = DAL.CurrentUser;
            ans.username = DAL.CurrentUser;
            DB.Insert(ques);
            DB.Insert(ans);
        }

       public static void AddAnswer (answers ans)
        {
            ans.username = DAL.CurrentUser;
            DB.Insert(ans);
        }

        public static QuestionsAnswers GetAllForQuestions(int thequesID)
        {
            var keyvalues = new { quesID = thequesID };
            string sql = "select * from answers where questionId=@quesID";
            QuestionsAnswers qa = new QuestionsAnswers();
            qa.ans = DB.Query<answers>(sql, keyvalues).ToList();
            //to get only one question we put in Get.
            qa.ques = DB.Get<Questions>(thequesID);
            return qa;
        }

        //public static List<Questions> SearchProduct(string ques)
        //{

        //    var keyvaluepair = new { search = "%" + ques + "%" };
        //    string sql = "select * from questions where detail like @search or title like @search";
        //    return DB.Query<answers>(sql, keyvaluepair).ToList();
        //}
    }
}

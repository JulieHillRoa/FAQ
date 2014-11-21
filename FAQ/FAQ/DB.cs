using FAQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FAQ
{
    public class DB
    {
        public List<Question> getQuestions(int id)
        {
            try
            {
                var db = new FAQDB();
                List<Question> question;
               
                    question = db.Questions.Select(q => new Question()
                    {
                        id = q.Id,
                        categoryid = q.Categoryid,
                        category = q.Category.Category,
                        date = q.Date.ToString(),
                        question = q.Question,
                        answer = q.Answer,
                        isfequant = q.Isfequant,
                        email = q.email,
                    }).Where(q => q.categoryid == id && q.answer != null).ToList();
                
                return question;

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<Category> getCategories(int? id)
        {
            try
            {
                var db = new FAQDB();
                List<Category> categories;

                if (id == null)
                {

                    categories = db.Categories.Select(c => new Category()
                    {
                        categoryID = c.CategoryId,
                        category = c.Category
                    }).ToList();
                }
                else 
                {
                    categories = db.Categories.Select(c => new Category()
                    {
                        categoryID = c.CategoryId,
                        category = c.Category
                    }).Where(q => q.categoryID == id).ToList();
                }
                foreach (var item in categories)
                {
                    item.questionlist = getQuestions(item.categoryID);
                }
                return categories;
            }
            catch 
            {
                return null;
            }
        }

        public bool addQuestion(Question q)
        {
            try
            {
                var db = new FAQDB();
                var newQuestion = new Questions()
                {
                     Categoryid = q.categoryid,
                     Category = db.Categories.Find(q.categoryid),
                     Date = DateTime.Now,
                     Question  = q.question,
                     Answer = q.answer,             
                     Isfequant = q.isfequant,
                     email = q.email,
                };

                db.Questions.Add(newQuestion);
                db.SaveChanges();
                return true;
            }
            catch (Exception failed)
            {
                return false;
            }
        }

        public bool updateQuestion(Question q, int id)
        {
            try
            {
                var db = new FAQDB();
                Questions question = db.Questions.FirstOrDefault(c => c.Id == q.id);
                question.Categoryid = q.categoryid;
                question.Date = DateTime.Now;
                question.Question = q.question;
                question.Answer = q.answer;
                question.Isfequant = true;
                question.email = null;

                var existingCategory = db.Categories.Find(q.categoryid);

                if (existingCategory == null)
                {
                    var newCatagory = new Categories()
                    {
                        Category = "support"
                    };
                    question.Category = newCatagory;
                }
                db.SaveChanges();
                return true;

            }
            catch 
            {
                return false;
            }
        }

        public List<Category> getCategoriesWithUnaswerdQuestions()
        {
            try
            {
                var db = new FAQDB();
                List<Category> categories;
                    categories = db.Categories.Select(c => new Category()
                    {
                        categoryID = c.CategoryId,
                        category = c.Category
                    }).ToList();

                foreach (var item in categories)
                {
                    item.questionlist = getUnansweredQuestions(item.categoryID);
                    foreach (var i in item.questionlist)
                        i.date = i.date.Substring(0, 11);
                }
                return categories;
            }
            catch
            {
                return null;
            }
        }

        public List<Question> getUnansweredQuestions(int id)
        {
            try
            {
                var db = new FAQDB();
                List<Question> question;
                    question = db.Questions.Select(q => new Question()
                    {
                        id = q.Id,
                        categoryid = q.Categoryid,
                        category = q.Category.Category,
                        date = q.Date.ToString(),
                        question = q.Question,
                        answer = q.Answer,
                        isfequant = q.Isfequant,
                        email = q.email,
                    }).Where(q => q.categoryid == id && q.answer == null).ToList();
                
                return question;

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Question getUnansweredQuestion(int id)
        {
            try
            {
                var db = new FAQDB();
                Questions questions = (Questions)db.Questions.FirstOrDefault(q => q.Id == id);
                Question question = new Question();

                question.id = questions.Id;
                question.categoryid = questions.Categoryid;
                question.category = db.Categories.Find(questions.Categoryid).Category;
                question.date = questions.Date.ToString();
                question.email = questions.email;
                question.question = questions.Question;
                question.answer = questions.Answer;
                question.isfequant = questions.Isfequant;
       
                return question;

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool removeQuestion(int id)
        {
            var db = new FAQDB();
            try
            {
                Questions q = db.Questions.FirstOrDefault(u => u.Id == id);
                db.Questions.Remove(q);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                
                return false;
            }
        }

    }
}
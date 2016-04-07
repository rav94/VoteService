using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace VoteService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "VoteServices" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select VoteServices.svc or VoteServices.svc.cs at the Solution Explorer and start debugging.
    public class VoteServices : IVoteServices, IPollServices,IQuestionServices, IAnswerServices, IUserServices
    {

        #region PollService
        public bool CreatePoll(PollEntity poll)
        {
            try
            {
                using (EVoteEntities entity = new EVoteEntities())
                {
                    var query = (from info in entity.PollEntities
                                 select info);

                    entity.PollEntities.Add(poll);
                    entity.SaveChanges();
                }
                return true;                
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool UpdatePoll(PollEntity poll)
        {
            try
            {
                using (EVoteEntities entity = new EVoteEntities())
                {
                    var query = (from Info in entity.PollEntities
                                 select Info);

                    if (query.Any())
                    {
                        entity.PollEntities.Remove(query.First());
                        entity.SaveChanges();

                        entity.PollEntities.Add(poll);
                        entity.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool DeletePoll(PollEntity poll)
        {
            try
            {
                using (EVoteEntities entity = new EVoteEntities())
                {
                  
                    var query = (from details in entity.PollEntities
                                     where details.Id == poll.Id &&
                                     details.Title == poll.Title
                                     select details);
                
                    if (query.Any())
                    {
                        entity.PollEntities.Remove(query.First());
                        entity.SaveChanges();
                    }
                    else
                    { 
                      return false;
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<PollEntity> FindAllPoll()
        {
            try
            {
                List<PollEntity> poll = new List<PollEntity>();
                using (EVoteEntities entity = new EVoteEntities())
                {
                    var query = (from info in entity.PollEntities
                                 select info);

                    if (query.Any())
                        poll = query.ToList();
                };
                return poll;
            }
            catch (Exception)
            {
                throw;
            }    
        }
        public PollEntity FindPollById(string id)
        {
            try
            {
                PollEntity poll = new PollEntity();
                int nid = Convert.ToInt32(id);
                using (EVoteEntities entity = new EVoteEntities())
                {
                    var query = (from info in entity.PollEntities
                                 where info.Id == nid
                                 select info);

                    if (query.Any())
                        poll = query.First();

                };
                return poll;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public PollEntity GetMaxPollID()
        {
            throw new NotImplementedException();
        }
        #endregion


        #region QuestionService
        public bool CreateQuestion(QuestionEntity question)
        {
            try
            {
                using (EVoteEntities entity = new EVoteEntities())
                {
                    var query = (from info in entity.QuestionEntities
                                 select info);

                    entity.QuestionEntities.Add(question);
                    entity.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool UpdateQuestion(QuestionEntity question)
        {
            try
            {
                using (EVoteEntities entity = new EVoteEntities())
                {
                    var query = (from Info in entity.QuestionEntities
                                 select Info);

                    if (query.Any())
                    {
                        entity.QuestionEntities.Remove(query.First());
                        entity.SaveChanges();

                        entity.QuestionEntities.Add(question);
                        entity.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool DeleteQuestion(QuestionEntity question)
        {
            try
            {
                using (EVoteEntities entity = new EVoteEntities())
                {
                    var query = (from details in entity.QuestionEntities
                                 where details.QuestionId == question.QuestionId &&
                                 details.PollId == question.PollId && details.Title == question.Title
                                 select details);

                    if (query.Any())
                    {
                        entity.QuestionEntities.Remove(query.First());
                        entity.SaveChanges();
                    }
                    else
                    {
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<QuestionEntity> FindAllQuestion()
        {
            try
            {
                List<QuestionEntity> question = new List<QuestionEntity>();
                using (EVoteEntities entity = new EVoteEntities())
                {
                    var query = (from info in entity.QuestionEntities
                                 select info);

                    if (query.Any())
                        question = query.ToList();
                };
                return question;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public QuestionEntity FindQuestionById(string id)
        {
            try
            {
                QuestionEntity question = new QuestionEntity();
                int nid = Convert.ToInt32(id);
                using (EVoteEntities entity = new EVoteEntities())
                {
                    var query = (from info in entity.QuestionEntities
                                 where info.QuestionId == nid
                                 select info);

                    if (query.Any())
                        question = query.First();

                };
                return question;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion


        #region AnswerService
        public bool CreateAnswer(AnswerEntity answer)
        {
            try
            {
                using (EVoteEntities entity = new EVoteEntities())
                {
                    var query = (from info in entity.AnswerEntities
                                 select info);

                    entity.AnswerEntities.Add(answer);
                    entity.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool UpdateAnswer(AnswerEntity answer)
        {
            try
            {
                using (EVoteEntities entity = new EVoteEntities())
                {
                    var query = (from Info in entity.AnswerEntities
                                 select Info);

                    if (query.Any())
                    {
                        entity.AnswerEntities.Remove(query.First());
                        entity.SaveChanges();

                        entity.AnswerEntities.Add(answer);
                        entity.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool DeleteAnswer(AnswerEntity answer)
        {
            try
            {
                using (EVoteEntities entity = new EVoteEntities())
                {
                    var query = (from details in entity.AnswerEntities
                                 where details.AnswerId == answer.AnswerId &&
                                 details.QuestionId == answer.QuestionId && details.Title == answer.Title
                                 select details);

                    if (query.Any())
                    {
                        entity.AnswerEntities.Remove(query.First());
                        entity.SaveChanges();
                    }
                    else
                    {
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public AnswerEntity FindAnswerById(string id)
        {
            try
            {
                AnswerEntity answer = new AnswerEntity();
                int nid = Convert.ToInt32(id);
                using (EVoteEntities entity = new EVoteEntities())
                {
                    var query = (from info in entity.AnswerEntities
                                 where info.AnswerId == nid
                                 select info);

                    if (query.Any())
                        answer = query.First();

                };
                return answer;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<AnswerEntity> FindAllAnswer()
        {
            try
            {
                List<AnswerEntity> answer = new List<AnswerEntity>();
                using (EVoteEntities entity = new EVoteEntities())
                {
                    var query = (from info in entity.AnswerEntities
                                 select info);

                    if (query.Any())
                        answer = query.ToList();
                };
                return answer;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion


        #region UserService
        public bool CreateUser(UserEntity user)
        {
            try
            {
                using (EVoteEntities entity = new EVoteEntities())
                {
                    var query = (from info in entity.UserEntities
                                 select info);

                    entity.UserEntities.Add(user);
                    entity.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool UpdateUser(UserEntity user)
        {
            try
            {
                using (EVoteEntities entity = new EVoteEntities())
                {
                    var query = (from Info in entity.UserEntities
                                 select Info);

                    if (query.Any())
                    {
                        entity.UserEntities.Remove(query.First());
                        entity.SaveChanges();

                        entity.UserEntities.Add(user);
                        entity.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool DeleteUser(UserEntity user)
        {
            try
            {
                using (EVoteEntities entity = new EVoteEntities())
                {
                    var query = (from details in entity.UserEntities
                                 where details.UserId == user.UserId &&
                                 details.UserName == user.UserName && details.UserPassword == user.UserPassword
                                 && details.UserEmail == user.UserEmail
                                 select details);

                    if (query.Any())
                    {
                        entity.UserEntities.Remove(query.First());
                        entity.SaveChanges();
                    }
                    else
                    {
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<UserEntity> FindAllUser()
        {
            try
            {
                List<UserEntity> user = new List<UserEntity>();
                using (EVoteEntities entity = new EVoteEntities())
                {
                    var query = (from info in entity.UserEntities
                                 select info);

                    if (query.Any())
                        user = query.ToList();
                };
                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public UserEntity FindUserById(string id)
        {
            try
            {
                UserEntity user = new UserEntity();
                int nid = Convert.ToInt32(id);
                using (EVoteEntities entity = new EVoteEntities())
                {
                    var query = (from info in entity.UserEntities
                                 where info.UserId == nid
                                 select info);

                    if (query.Any())
                        user = query.First();

                };
                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        #endregion
    }
}



//using (EVoteEntities entity = new EVoteEntities())
//{
//    PollEntity pl = new PollEntity();
//    pl.Id = poll.Id;
//    pl.Title = poll.Title;
//    entity.PollEntities.Add(pl);
//    entity.SaveChanges();
//    return true;
//}

//using (EVoteEntities entity = new EVoteEntities()) {
//    return entity.PollEntities.Select(pl => new PollEntity
//    {
//        Id = pl.Id,
//        Title = pl.Title
//    }).ToList();
//}

//int id = Convert.ToInt32(poll.Id);
//PollEntity pl = entity.PollEntities.Single(p => p.Id == poll.Id);
//entity.PollEntities.Remove(pl);
//entity.SaveChanges();
//return true;

//int id = Convert.ToInt32(poll.Id);
//PollEntity pl = entity.PollEntities.Single(p => p.Id == poll.Id);
//pl.Id = poll.Id;
//pl.Title = poll.Title;
//entity.SaveChanges();
//return true;
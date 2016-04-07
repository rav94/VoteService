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
        public bool CreatePoll(Poll poll)
        {
            try
            {
                //using (EVoteEntities entity = new EVoteEntities())
                //{
                //    var query = (from info in entity.PollEntities
                //                 select info);

                //    entity.PollEntities.Add(poll);
                //    entity.SaveChanges();
                //}
                //return true;


                using (EVoteEntities entity = new EVoteEntities())
                {
                    PollEntity pl = new PollEntity();
                    pl.Id = poll.Id;
                    pl.Title = poll.Title;
                    entity.PollEntities.Add(pl);
                    entity.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool UpdatePoll(Poll poll)
        {
            try
            {
                using (EVoteEntities entity = new EVoteEntities())
                {
                    int id = Convert.ToInt32(poll.Id);
                    PollEntity pl = entity.PollEntities.Single(p => p.Id == poll.Id);
                    pl.Id = poll.Id;
                    pl.Title = poll.Title;
                    entity.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool DeletePoll(Poll poll)
        {
            try
            {
                using (EVoteEntities entity = new EVoteEntities())
                {
                    int id = Convert.ToInt32(poll.Id);
                    PollEntity pl = entity.PollEntities.Single(p => p.Id == poll.Id);
                    entity.PollEntities.Remove(pl);
                    entity.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Poll> FindAllPoll()
        {
            using (EVoteEntities entity = new EVoteEntities()) {
                return entity.PollEntities.Select(pl => new Poll
                {
                    Id = pl.Id,
                    Title = pl.Title
                }).ToList();
            }
        }
        public Poll FindPollById(string id)
        {
            using (EVoteEntities entity = new EVoteEntities())
            {
                int nid = Convert.ToInt32(id);
                return entity.PollEntities.Where(pl => pl.Id == nid).Select(pl => new Poll
                {
                    Id = pl.Id,
                    Title = pl.Title
                }).First();

            }
        }
        public Poll GetMaxPollID()
        {
            throw new NotImplementedException();
        }
        #endregion


        #region QuestionService
        public bool CreateQuestion(Question question)
        {
            throw new NotImplementedException();
        }
        public bool UpdateQuestion(Question question)
        {
            throw new NotImplementedException();
        }
        public bool DeleteQuestion(Question question)
        {
            throw new NotImplementedException();
        }
        public List<Question> FindAllQuestion()
        {
            throw new NotImplementedException();
        }
        public Question FindQuestionById(string id)
        {
            throw new NotImplementedException();
        }
        #endregion


        #region AnswerService
        public bool CreateAnswer(Answer answer)
        {
            throw new NotImplementedException();
        }
        public bool UpdateAnswer(Answer answer)
        {
            throw new NotImplementedException();
        }
        public bool DeleteAnswer(Answer answer)
        {
            throw new NotImplementedException();
        }
        public Answer FindAnswerById(string id)
        {
            throw new NotImplementedException();
        }
        public List<Answer> FindAllAnswer()
        {
            throw new NotImplementedException();
        }
        #endregion


        #region UserService
        public List<User> FindAllUser()
        {
            throw new NotImplementedException();
        }
        public bool DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public User FindUserById(string id)
        {
            throw new NotImplementedException();
        }
        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}

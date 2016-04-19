using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace VoteService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IVoteServices" in both code and config file together.
    [ServiceContract]
    public interface IVoteServices
    {
        
    }

    #region Poll
    [ServiceContract]
    public interface IPollServices
    {
        //Create a Poll
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        bool CreatePoll(PollEntity poll);

        //Edit the Poll --> Not Actually Implemented
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool UpdatePoll(PollEntity poll);

        //Delete the Poll --> Not Actually Implemnted
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool DeletePoll(PollEntity poll);

        //Find and return all the Polls.
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findPoll", ResponseFormat = WebMessageFormat.Json)]
        List<PollEntity> FindAllPoll();

        //Find a Poll by a ID
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findPoll/{id}", ResponseFormat = WebMessageFormat.Json)]
        PollEntity FindPollById(string id);

        //To obtain the poll by the Maximum number of the poll --> Not Actually Implemented
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "pollMaxId", ResponseFormat = WebMessageFormat.Json)]
        PollEntity GetMaxPollID();

        //Obtain Poll By User
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getPollByUser/{id}", ResponseFormat = WebMessageFormat.Json)]
        List<PollEntity> GetPollByUserId(string id);

        //Obtain Answer By Poll
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getAnswerByPoll/{id}", ResponseFormat = WebMessageFormat.Json)]
        List<Poll> GetAnswerByPoll(string id);

    }
    #endregion

    #region Answer
    [ServiceContract]
    public interface IAnswerServices
    {
        //Create Answers for a Poll
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        bool CreateAnswer(AnswerEntity answer);

        //Edit Answers of a Poll
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool UpdateAnswer(AnswerEntity answer);

        //Delete Answers of a Poll
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool DeleteAnswer(AnswerEntity answer);

        //Find All the Answers
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findAnswer", ResponseFormat = WebMessageFormat.Json)]
        List<AnswerEntity> FindAllAnswer();

        //Find Answers of Poll based on an ID
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findAnswer/{id}", ResponseFormat = WebMessageFormat.Json)]
        AnswerEntity FindAnswerById(string id);
    }
    #endregion

    #region User
    [ServiceContract]
    public interface IUserServices
    {
        //User Create
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        bool CreateUser(UserEntity user);

        //Edit a User --> Not Actually Implemented
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool UpdateUser(UserEntity user);

        //Dekete a User
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool DeleteUser(UserEntity user);

        //Find All the regsitered users
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findUser", ResponseFormat = WebMessageFormat.Json)]
        List<UserEntity> FindAllUser();

        //Find a user based on the Id
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findUser/{id}", ResponseFormat = WebMessageFormat.Json)]
        UserEntity FindUserById(string id);
    }
    #endregion

    #region Stats 
    //Service for a Statistic Service
    [ServiceContract]
    public interface IStatServices
    {
        //Create a Stat
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        bool CreateStat(StatEntity stat);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findStat", ResponseFormat = WebMessageFormat.Json)]
        List<StatEntity> FindAllStat();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findStat/{id}", ResponseFormat = WebMessageFormat.Json)]
        StatEntity FindStatById(string Id);
    }
    #endregion
}


//#region Question
//[ServiceContract]
//public interface IQuestionServices
//{
//    [OperationContract]
//    [WebInvoke(Method = "POST", UriTemplate = "create", ResponseFormat = WebMessageFormat.Json,
//        RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
//    bool CreateQuestion(QuestionEntity question);

//    [OperationContract]
//    [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
//    bool UpdateQuestion(QuestionEntity question);

//    [OperationContract]
//    [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
//    bool DeleteQuestion(QuestionEntity question);

//    [OperationContract]
//    [WebInvoke(Method = "GET", UriTemplate = "findQuestion", ResponseFormat = WebMessageFormat.Json)]
//    List<QuestionEntity> FindAllQuestion();

//    [OperationContract]
//    [WebInvoke(Method = "GET", UriTemplate = "findQuestion/{id}", ResponseFormat = WebMessageFormat.Json)]
//    QuestionEntity FindQuestionById(string id);
//}
//#endregion
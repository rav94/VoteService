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
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        bool CreatePoll(PollEntity poll);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool UpdatePoll(PollEntity poll);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool DeletePoll(PollEntity poll);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findPoll", ResponseFormat = WebMessageFormat.Json)]
        List<PollEntity> FindAllPoll();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findPoll/{id}", ResponseFormat = WebMessageFormat.Json)]
        PollEntity FindPollById(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "pollMaxId", ResponseFormat = WebMessageFormat.Json)]
        PollEntity GetMaxPollID();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getPollByUser/{id}", ResponseFormat = WebMessageFormat.Json)]
        List<PollEntity> GetPollByUserId(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getAnswerByPoll/{id}", ResponseFormat = WebMessageFormat.Json)]
        List<Poll> GetAnswerByPoll(string id);

    }
    #endregion

    #region Answer
    [ServiceContract]
    public interface IAnswerServices
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        bool CreateAnswer(AnswerEntity answer);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool UpdateAnswer(AnswerEntity answer);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool DeleteAnswer(AnswerEntity answer);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findAnswer", ResponseFormat = WebMessageFormat.Json)]
        List<AnswerEntity> FindAllAnswer();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findAnswer/{id}", ResponseFormat = WebMessageFormat.Json)]
        AnswerEntity FindAnswerById(string id);
    }
    #endregion

    #region User
    [ServiceContract]
    public interface IUserServices
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        bool CreateUser(UserEntity user);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool UpdateUser(UserEntity user);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool DeleteUser(UserEntity user);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findUser", ResponseFormat = WebMessageFormat.Json)]
        List<UserEntity> FindAllUser();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findUser/{id}", ResponseFormat = WebMessageFormat.Json)]
        UserEntity FindUserById(string id);
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
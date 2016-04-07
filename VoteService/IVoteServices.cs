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
        bool CreatePoll(Poll poll);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool UpdatePoll(Poll poll);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool DeletePoll(Poll poll);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findPoll", ResponseFormat = WebMessageFormat.Json)]
        List<Poll> FindAllPoll();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findPoll/{id}", ResponseFormat = WebMessageFormat.Json)]
        Poll FindPollById(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "pollMaxId", ResponseFormat = WebMessageFormat.Json)]
        Poll GetMaxPollID();
    }
    #endregion

    #region Question
    [ServiceContract]
    public interface IQuestionServices
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        bool CreateQuestion(Question question);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool UpdateQuestion(Question question);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool DeleteQuestion(Question question);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findQuestion", ResponseFormat = WebMessageFormat.Json)]
        List<Question> FindAllQuestion();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findQuestion/{id}", ResponseFormat = WebMessageFormat.Json)]
        Question FindQuestionById(string id);
    }
    #endregion

    #region Answer
    [ServiceContract]
    public interface IAnswerServices
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        bool CreateAnswer(Answer answer);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool UpdateAnswer(Answer answer);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool DeleteAnswer(Answer answer);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findAnswer", ResponseFormat = WebMessageFormat.Json)]
        List<Answer> FindAllAnswer();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findAnswer/{id}", ResponseFormat = WebMessageFormat.Json)]
        Answer FindAnswerById(string id);
    }
    #endregion

    #region User
    [ServiceContract]
    public interface IUserServices
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        bool CreateUser(User user);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool UpdateUser(User user);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool DeleteUser(User user);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findUser", ResponseFormat = WebMessageFormat.Json)]
        List<User> FindAllUser();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findUser/{id}", ResponseFormat = WebMessageFormat.Json)]
        User FindUserById(string id);
    }
    #endregion
}

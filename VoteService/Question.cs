using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VoteService
{
    public class Question
    {
        public int QuestionId { get; set; }
        public int PollId { get; set; }
        public string Title { get; set; }
    }
}
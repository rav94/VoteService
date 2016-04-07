using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VoteService
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public string Title { get; set; }
    }
}
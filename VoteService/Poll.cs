using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VoteService
{
    public class Poll
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string AnswerOne { get; set; }
        public string AnswerTwo { get; set; }
        public string AnswerThree { get; set; }
        public string AnswerFour { get; set; }
    }
}
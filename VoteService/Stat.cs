using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VoteService
{
    public class Stat
    {
        public int StatId { get; set; }
        public Nullable<int> PollId { get; set; }
        public Nullable<int> AnswerOneId { get; set; }
        public Nullable<int> AnswerTwoId { get; set; }
        public Nullable<int> AnswerThreeId { get; set; }
        public Nullable<int> AnswerFourId { get; set; }
    }
}
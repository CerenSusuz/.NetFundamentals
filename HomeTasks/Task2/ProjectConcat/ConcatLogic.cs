using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectConcat
{
    public class ConcatLogic
    {
        public ConcatLogic()
        {
            CurrentTime = DateTime.Now;
        }

        public DateTime CurrentTime { get; set; }

        public string Concat(string username)
        {
            string result = $"{CurrentTime} Hello, {username}!";
            return result;
        }

        public string ConcatTypeTwo(string username)
        {
            string result = CurrentTime + " Hello, " + username + "!";
            return result;
        }
    }
}

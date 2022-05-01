using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveyWebApp
{
    public class ResultStatus
    {
        //Class used to display messages when a user register as member
        private int resultStatuscode;
        private string message;

        public int ResultStatuscode { get => resultStatuscode; set => resultStatuscode = value; }
        public string Message { get => message; set => message = value; }
    }
}
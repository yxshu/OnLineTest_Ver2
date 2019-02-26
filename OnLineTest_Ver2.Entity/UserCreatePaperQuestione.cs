using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class UserCreatePaperQuestione
    {
        /*
        UserCreatePaperQuestioneId int identity(1,1) primary key,-----ID
		UserCreatePaperId int not null references UserCreatePaper(UserCreatePaperId),-----试卷信息ID
		QuestionId int not null references QuestionFORGeneral(QuestionId)-----试题ID
         */
        private int userCreatePaperQuestioneId;
        private UserCreatePaper userCreatePaper;
        private QuestionFORGeneral question;

        public int UserCreatePaperQuestioneId { get => userCreatePaperQuestioneId; set => userCreatePaperQuestioneId = value; }
        public UserCreatePaper UserCreatePaper { get => userCreatePaper; set => userCreatePaper = value; }
        public QuestionFORGeneral Question { get => question; set => question = value; }
    }
}

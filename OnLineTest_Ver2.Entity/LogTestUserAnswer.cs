using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class LogTestUserAnswer
    {
        /*
        LogTestUserAnswerId int identity(1,1) primary key,-----ID
		LogTestId int not null references LogTest(LogTestId),-----外键 测试信息ID
		QuestionId int not null references QuestionFORGeneral(QuestionId),-----外键 试题ID
		LogTestUserAnswer int,-----测试时给出的答案
		LogTestUserAnswerRemark varchar(max)-----备注
         */
        private int logTestUserAnswerId;
        private LogTest logTest;
        private QuestionFORGeneral question;
        private int userAnswer;
        private string logTestUserAnswerRemark;

        public int LogTestUserAnswerId { get => logTestUserAnswerId; set => logTestUserAnswerId = value; }
        public int UserAnswer { get => userAnswer; set => userAnswer = value; }
        public string LogTestUserAnswerRemark { get => logTestUserAnswerRemark; set => logTestUserAnswerRemark = value; }
        public LogTest LogTest { get => logTest; set => logTest = value; }
        public QuestionFORGeneral Question { get => question; set => question = value; }
    }
}

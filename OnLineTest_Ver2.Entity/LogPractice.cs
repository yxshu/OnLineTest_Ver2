using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class LogPractice
    {
        /*
        LogPracticeId int identity(1,1) primary key,-----ID
		userId int not null references Users(UserId),-----用户ID
		QuestionId int not null references QuestionFORGeneral(QuestionId),-----试题ID
		LogPracticeTime datetime not null default getdate(),-----练习时间
		LogPracticeAnswer int,-----练习时给出的答案
		LogPracetimeRemark text null-----备注
         */
        private int logPracticeId;
        private Users user;
        private QuestionFORGeneral question;
        private DateTime logPracticeTime;
        private int logPracticeAnswer;
        private string logPracetimeRemark;

        public int LogPracticeId { get => logPracticeId; set => logPracticeId = value; }
        public DateTime LogPracticeTime { get => logPracticeTime; set => logPracticeTime = value; }
        public int LogPracticeAnswer { get => logPracticeAnswer; set => logPracticeAnswer = value; }
        public string LogPracetimeRemark { get => logPracetimeRemark; set => logPracetimeRemark = value; }
        public Users User { get => user; set => user = value; }
        public QuestionFORGeneral Question { get => question; set => question = value; }
    }
}

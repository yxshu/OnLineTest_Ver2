using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class VerifyStatus
    {
        /*
        VerifyStatusId int identity(1,1) primary key,-----审核状态ID
		QuestionId int not null references QuestionFORGeneral(QuestionId),-----与试题库中对应的试题ID（要审核通过以后才能更新到试题库）
		UserId int not null references Users(UserId),-----审核人ID
		Stamp bit not null default 0,-----是否通过标记
		VerifyTime datetime not null default getdate(),-----审核时间
		NewQuestinId int foreign key references  QuestionFORGeneral(QuestionId),
		Remark varchar(max)
         */
        private int verifyStatusId;
        private QuestionFORGeneral question;
        private Users user;
        private bool stamp;
        private DateTime verifyTime;
        private QuestionFORGeneral newQuestin;
        private string remark;

        public int VerifyStatusId { get => verifyStatusId; set => verifyStatusId = value; }
        public bool Stamp { get => stamp; set => stamp = value; }
        public DateTime VerifyTime { get => verifyTime; set => verifyTime = value; }
        public string Remark { get => remark; set => remark = value; }
        public QuestionFORGeneral Question { get => question; set => question = value; }
        public Users User { get => user; set => user = value; }
        public QuestionFORGeneral NewQuestin { get => newQuestin; set => newQuestin = value; }
    }
}

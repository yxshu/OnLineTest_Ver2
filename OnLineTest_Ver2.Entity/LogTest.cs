using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class LogTest
    {
        /*
        LogTestId int identity(1,1) primary key,-----ID
		UserId int not null references Users(UserId),-----用户ID
		UserCreatePaperId int not null foreign key references UserCreatePaper(UserCreatePaperId),---哪一套试卷
		LogTestStartTime datetime not null default getdate(),-----测试时间
        LogTestEndTime datetime null,		
		LogTestScore int not null default 0-----测试的得分，默认为0分
         */
        private int logTestId;
        private Users user;
        private UserCreatePaper userCreatePaper;
        private DateTime logTestStartTime;
        private DateTime logTestEndTime;
        private int logTestScore;

        public int LogTestId { get => logTestId; set => logTestId = value; }
        public DateTime LogTestStartTime { get => logTestStartTime; set => logTestStartTime = value; }
        public DateTime LogTestEndTime { get => logTestEndTime; set => logTestEndTime = value; }
        public int LogTestScore { get => logTestScore; set => logTestScore = value; }
        public Users User { get => user; set => user = value; }
        public UserCreatePaper UserCreatePaper { get => userCreatePaper; set => userCreatePaper = value; }
    }
}

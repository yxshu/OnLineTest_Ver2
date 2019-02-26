using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class UserCreatePaper
    {
        /*
        UserCreatePaperId int identity(1,1) primary key,-----ID
        UserId int not null references Users(UserId),-----用户ID
        PaperCodeId int not null references PaperCode(PaperCodeId),-----试卷代码Id
        DifficultyId int not null references Difficulty(DifficultyId),-----难度系数
        UserCreatePaperTime datetime not null default getdate()-----生成时间 
        */
        private int userCreatePaperId;
        private Users user;
        private PaperCode paperCode;
        private Difficulty difficulty;
        private DateTime userCreatePaperTime;

        public int UserCreatePaperId { get => userCreatePaperId; set => userCreatePaperId = value; }
        public DateTime UserCreatePaperTime { get => userCreatePaperTime; set => userCreatePaperTime = value; }
        public Users User { get => user; set => user = value; }
        public PaperCode PaperCode { get => paperCode; set => paperCode = value; }
        public Difficulty Difficulty { get => difficulty; set => difficulty = value; }
    }
}

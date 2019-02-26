using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class UserRank
    {
        /*
		UserRankId int identity(1,1) primary key,-----等级ID
		UserRankName varchar(50) not null unique,-----等级对应的中文名称
		MinScore int not null check(MinScore>=0),-----等级所对应的最低分
		MaxScore int not null check(MaxScore>=0),-----等级所对应的最高分
             */
        private int userRankId;
        private string userRankName;
        private int minScore;
        private int maxScore;

        public int UserRankId { get => userRankId; set => userRankId = value; }
        public string UserRankName { get => userRankName; set => userRankName = value; }
        public int MinScore { get => minScore; set => minScore = value; }
        public int MaxScore { get => maxScore; set => maxScore = value; }
    }
}

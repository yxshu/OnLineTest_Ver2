using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class Difficulty
    {
        /*
		DifficultyId int identity(1,1) primary key,-----难度系数ID
		DifficultyRatio int not null default 0 check( DifficultyRatio>=0 and DifficultyRatio<=10),-----难度系数0-10
		DifficultyDescrip varchar(50) not null,-----难度系数对应的描述
		DifficultyRemark varchar(max)-----备注
         */
        private int difficultyId;
        private int difficultyRatio;
        private string difficultyDescrip;
        private string difficultyRemark;

        public int DifficultyId { get => difficultyId; set => difficultyId = value; }
        public int DifficultyRatio { get => difficultyRatio; set => difficultyRatio = value; }
        public string DifficultyDescrip { get => difficultyDescrip; set => difficultyDescrip = value; }
        public string DifficultyRemark { get => difficultyRemark; set => difficultyRemark = value; }
    }
}

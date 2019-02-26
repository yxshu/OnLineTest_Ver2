using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class Level
    {
        /*
	LevelId int identity(1,1) primary key,
	LevelName varchar(50) not null,---层级说明，包括船长，大副，二副等
	LevelRemark varchar(max),
         */
        private int levelId;
        private string levelName;
        private string levelRemark;

        public int LevelId { get => levelId; set => levelId = value; }
        public string LevelName { get => levelName; set => levelName = value; }
        public string LevelRemark { get => levelRemark; set => levelRemark = value; }
    }
}

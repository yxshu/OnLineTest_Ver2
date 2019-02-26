using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class PaperCode
    {
        /*
		PaperCodeId int identity(1,1) primary key,-----试卷代码ID
		LevelId int not null foreign key references Level(LevelId),---层级
		SubjectId int not null foreign key references Subject(SubjectId),-----试卷代码所对应的科目ID，外键
		Code int not null unique,-----试卷代码
		ChineseName varchar(200) not null,-----试卷代码所对应的中文名称
		PaperCodePassScore int not null check(PaperCodePassScore>0),-----试卷代码的及格分数线
		PaperCodeTotalScore int not null, ---check(PaperCodeTotalScore>PaperCodePassScore),-----试卷代码的总分
		TimeRange int not null check(TimeRange>0),-----试卷代码考试的时长
		PaperCodeRemark varchar(max) null,-----试卷代码的备注
		constraint PaperCodeTotalScore_PaperCodePassScore_check check(PaperCodeTotalScore>PaperCodePassScore)
         */
        private int paperCodeId;
        private Level level;
        private Subject subject;
        private int code;
        private string chineseName;
        private int paperCodePassScore;
        private int paperCodeTotalScore;
        private int timeRange;
        private string paperCodeRemark;

        public int PaperCodeId { get => paperCodeId; set => paperCodeId = value; }
        public int Code { get => code; set => code = value; }
        public string ChineseName { get => chineseName; set => chineseName = value; }
        public int PaperCodePassScore { get => paperCodePassScore; set => paperCodePassScore = value; }
        public int PaperCodeTotalScore { get => paperCodeTotalScore; set => paperCodeTotalScore = value; }
        public int TimeRange { get => timeRange; set => timeRange = value; }
        public string PaperCodeRemark { get => paperCodeRemark; set => paperCodeRemark = value; }
        internal Level Level { get => level; set => level = value; }
        internal Subject Subject { get => subject; set => subject = value; }
    }
}

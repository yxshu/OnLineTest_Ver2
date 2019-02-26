using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class PastExamPaper
    {
        /*
		PastExamPaperId int identity(1,1) primary key,-----ID
		ExamZoneId int not null foreign key references ExamZone(ExamZoneId),-----真题对应的考区信息
		PaperCodeId int not null foreign key references PaperCode(PaperCodeId),-----真题对应的试卷代码
		PastExamPaperPeriodNo int not null,-----期数
		PastExamPaperDatetime datetime not null,-----考试的时间
         */
        private int pastExamPaperId;
        private ExamZone examZone;
        private PaperCode paperCode;
        private int pastExamPaperPeriodNo;
        private DateTime pastExamPaperDatetime;

        public int PastExamPaperId { get => pastExamPaperId; set => pastExamPaperId = value; }
        public int PastExamPaperPeriodNo { get => pastExamPaperPeriodNo; set => pastExamPaperPeriodNo = value; }
        public DateTime PastExamPaperDatetime { get => pastExamPaperDatetime; set => pastExamPaperDatetime = value; }
        internal ExamZone ExamZone { get => examZone; set => examZone = value; }
        internal PaperCode PaperCode { get => paperCode; set => paperCode = value; }
    }
}

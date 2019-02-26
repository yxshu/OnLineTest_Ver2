using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class Syllabus
    {
        /*
	SyllabusId int identity(1,1) primary key,
	PaperCodeId int not null foreign key references PaperCode(PaperCodeId),
	ChapterId int not null foreign key references Chapter(ChapterId),
	SyllabusRemark varchar(max)
         */
        private int syllabusId;
        private PaperCode paperCode;
        private Chapter chapter;
        private string syllabusRemark;

        public int SyllabusId { get => syllabusId; set => syllabusId = value; }
        public string SyllabusRemark { get => syllabusRemark; set => syllabusRemark = value; }
        public PaperCode PaperCode { get => paperCode; set => paperCode = value; }
        public Chapter Chapter { get => chapter; set => chapter = value; }
    }
}

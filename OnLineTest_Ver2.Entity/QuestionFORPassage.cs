using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class QuestionFORPassage : QuestionFORGeneral
    {
        /*
	QuestionFORPassageId int identity(1,1) primary key,
	QuestionFORDanxuanId int not null foreign key references QuestionFORDanxuan(QuestionFORDanxuanId),
	PassageId int references Passage(PassageId)
         */
        private  int questionFORPassageId;
        private  QuestionFORDanxuan questionFORDanxuan;
        private  Passage passage;

        public int QuestionFORPassageId { get => questionFORPassageId; set => questionFORPassageId = value; }
        public QuestionFORDanxuan QuestionFORDanxuan { get => questionFORDanxuan; set => questionFORDanxuan = value; }
        public Passage Passage { get => passage; set => passage = value; }
    }
}

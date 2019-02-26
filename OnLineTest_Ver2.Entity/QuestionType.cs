using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class QuestionType
    {
        /*
	QuestionTypeId int identity(1,1) primary key,
	QuestionTypeDescrip varchar(20) not null,
	QuestionTypeRemark varchar(max)
         */
        private int questionTypeId;
        private string questionTypeDescrip;
        private string questionTypeRemark;

        public int QuestionTypeId { get => questionTypeId; set => questionTypeId = value; }
        public string QuestionTypeDescrip { get => questionTypeDescrip; set => questionTypeDescrip = value; }
        public string QuestionTypeRemark { get => questionTypeRemark; set => questionTypeRemark = value; }
    }
}

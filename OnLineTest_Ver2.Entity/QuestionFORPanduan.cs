using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class QuestionFORPanduan : QuestionFORGeneral
    {
        /*
    QuestionFORPanduanId int identity(1,1) primary key,
	QuestionId int not null foreign key references QuestionFORGeneral(QuestionId),
	CorrectAnswer bit  not null
         */
        private int questionFORPanduanId;
        private QuestionFORGeneral questionFORGeneral;
        private bool correctAnswer;

        public int QuestionFORPanduanId { get => questionFORPanduanId; set => questionFORPanduanId = value; }
        public bool CorrectAnswer { get => correctAnswer; set => correctAnswer = value; }
        public QuestionFORGeneral QuestionFORGeneral { get => questionFORGeneral; set => questionFORGeneral = value; }
    }
}

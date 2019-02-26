using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class QuestionFORDanxuan : QuestionFORGeneral
    {
        /*
    QuestionFORDanxuanId int identity(1,1) primary key,
	QuestionId int not null foreign key references QuestionFORGeneral(QuestionId),
	AnswerA varchar(max)  not null,
	AnswerB varchar(max)  not null,
	AnswerC varchar(max)  not null,
	AnswerD varchar(max)  not null,
	CorrectAnswer int  not null check(CorrectAnswer in(1,2,3,4))
         */
        private int questionFORDanxuanId;
        private QuestionFORGeneral questionFORGeneral;
        private string answerA;
        private string answerB;
        private string answerC;
        private string answerD;
        private int correctAnswer;

        public int QuestionFORDanxuanId { get => questionFORDanxuanId; set => questionFORDanxuanId = value; }
        public string AnswerA { get => answerA; set => answerA = value; }
        public string AnswerB { get => answerB; set => answerB = value; }
        public string AnswerC { get => answerC; set => answerC = value; }
        public string AnswerD { get => answerD; set => answerD = value; }
        public int CorrectAnswer { get => correctAnswer; set => correctAnswer = value; }
        public QuestionFORGeneral QuestionFORGeneral { get => questionFORGeneral; set => questionFORGeneral = value; }
    }
}

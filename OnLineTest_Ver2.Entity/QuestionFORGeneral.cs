using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class QuestionFORGeneral
    {
        /*
		QuestionId int identity(1,1) primary key,-----试题ID
		QuestionType int not null foreign key references QuestionType(QuestionTypeId),----试题的类型
		QuestionTitle varchar(max) not null,-----题目
		Explain varchar(max),-----解析
		ImagePath varchar(200),-----图形名称
		DifficultyId int not null references Difficulty(DifficultyId),-----难度系数
		UserId int not null references Users(UserId),-----上传人ID
		UpLoadTime datetime not null default getdate(),-----上传时间
		VerifyTimes int not null default 0,-----被审核次数（三次以上有效）
		IsDelte bit not null default 0,-----软删除标记
		IsSupported int not null default 0,-----被赞次数
		IsDeSupported int not null default 0,-----被踩次数
		PaperCodeId int not null references PaperCode(PaperCodeId),-----试题所对应的试卷代码
		ChapterId int not null references Chapter(ChapterId),-----试题所对应的章节
		PastExamPaperId int references PastExamPaper(PastExamPaperId),-----试题是否是历年真题
		PastExamQuestionId int, -----如果是真题，则在真题中的题号
		Remark varchar(max) ---------备注
         */
        private int questionId;
        private QuestionType questionType;
        private string questionTitle;
        private string explain;
        private string imagePath;
        private Difficulty difficulty;
        private Users user;
        private DateTime upLoadTime;
        private int verifyTimes;
        private bool isDelte;
        private int isSupported;
        private int isDeSupported;
        private PaperCode paperCode;
        private Chapter chapter;
        private PastExamPaper pastExamPaper;
        private int pastExamQuestionId;
        private string remark;

        public int QuestionId { get => questionId; set => questionId = value; }
        public string QuestionTitle { get => questionTitle; set => questionTitle = value; }
        public string Explain { get => explain; set => explain = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
        public DateTime UpLoadTime { get => upLoadTime; set => upLoadTime = value; }
        public int VerifyTimes { get => verifyTimes; set => verifyTimes = value; }
        public bool IsDelte { get => isDelte; set => isDelte = value; }
        public int IsSupported { get => isSupported; set => isSupported = value; }
        public int IsDeSupported { get => isDeSupported; set => isDeSupported = value; }
        public int PastExamQuestionId { get => pastExamQuestionId; set => pastExamQuestionId = value; }
        public string Remark { get => remark; set => remark = value; }
        public QuestionType QuestionType { get => questionType; set => questionType = value; }
        public Difficulty Difficulty { get => difficulty; set => difficulty = value; }
        public Users User { get => user; set => user = value; }
        public PaperCode PaperCode { get => paperCode; set => paperCode = value; }
        public Chapter Chapter { get => chapter; set => chapter = value; }
        public PastExamPaper PastExamPaper { get => pastExamPaper; set => pastExamPaper = value; }
    }
}

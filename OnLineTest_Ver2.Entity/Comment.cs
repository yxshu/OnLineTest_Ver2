using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class Comment
    {
        /*
        CommentId int identity(1,1) primary key,-----ID
		QuestionId int not null references QuestionFORGeneral(QuestionId),-----外键 试题ID
		UserId int not null references Users(UserId),-----外键 用户ID
		CommentContent text not null,-----评论的内容
		CommentTime datetime not null default getdate(),-----发表评论的时间
		QuoteCommentId int null references Comment(CommentId),-----引用的评论
		IsDeleted bit not null default 0,-----是否删除	
		DeleteUserId int null references Users(UserId),-----外键 删除评论人
		DeleteCommentTime datetime null -----删除评论时间
         */
        private  int commentId;
        private  QuestionFORGeneral questionFORGeneral;
        private  Users user;
        private  string commentContent;
        private  DateTime commentTime;
        private  Comment quoteComment;
        private  bool isDeleted;
        private  Users deleteUser;
        private  DateTime deleteCommentTime;

        public int CommentId { get => commentId; set => commentId = value; }
        public QuestionFORGeneral QuestionFORGeneral { get => questionFORGeneral; set => questionFORGeneral = value; }
        public Users User { get => user; set => user = value; }
        public string CommentContent { get => commentContent; set => commentContent = value; }
        public DateTime CommentTime { get => commentTime; set => commentTime = value; }
        public Comment QuoteComment { get => quoteComment; set => quoteComment = value; }
        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }
        public Users DeleteUser { get => deleteUser; set => deleteUser = value; }
        public DateTime DeleteCommentTime { get => deleteCommentTime; set => deleteCommentTime = value; }
    }
}

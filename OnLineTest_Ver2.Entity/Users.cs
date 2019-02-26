using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
   public class Users
    {
        /*
          UserId int identity(1,1) primary key,-----用户ID号
          UserName varchar(50) not null unique,-----登录名
          UserPassword varchar(200) not null,----登录密码，要求使用MD5格式存储
          UserChineseName varchar(50) not null default '-',------用户名称
          UserImagePath varchar(200) not null default('default.jpg'),
          UserEmail varchar(50) not null unique,-----用户电子邮件
          IsValidate bit not null default 0,-----是否通过电子邮件验证
          Tel varchar(20) null,
          UserScore int not null default 0 ,-----用户的论坛分值
          UserRegisterDatetime datetime not null default getdate(),-----用户注册时间
          UserLoginStatus bit not null default 0,------用户是否登录标记0为未登录,1为登录
          UserGroupId int not null default(1) foreign key references UserGroup(UserGroupId),
           */
        private int userId;
        private string userName;
        private string userPassword;
        private string userChineseName;
        private string userImagePath;
        private string userEmail;
        private bool isValidate;
        private string tel;
        private int userScore;
        private DateTime userRegisterDatetime;
        private bool userLoginStatus;
        private UserGroup userGroup;
        public int UserId { get => userId; set => userId = value; }
        public string UserName { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public string UserChineseName { get => userChineseName; set => userChineseName = value; }
        public string UserImagePath { get => userImagePath; set => userImagePath = value; }
        public string UserEmail { get => userEmail; set => userEmail = value; }
        public bool IsValidate { get => isValidate; set => isValidate = value; }
        public string Tel { get => tel; set => tel = value; }
        public int UserScore { get => userScore; set => userScore = value; }
        public DateTime UserRegisterDatetime { get => userRegisterDatetime; set => userRegisterDatetime = value; }
        public bool UserLoginStatus { get => userLoginStatus; set => userLoginStatus = value; }
        public UserGroup UserGroup { get => userGroup; set => userGroup = value; }
    }
}

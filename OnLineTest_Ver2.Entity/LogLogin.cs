using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class LogLogin
    {
        /*
        LogLoginId int identity(1,1) primary key,-----ID
		UserId int not null references Users(UserID),-----用户ID
		LogLoginTime datetime not null default getdate(),-----登录时间
		LogLogoutTime datetime,-----登出时间
		LogLoginIp varchar(20) not null default('127.0.0.1'),-----登录IP
		LogLoginOperatiionSystem nvarchar(200) null,-----登录时所用的操作系统
		LogLoginWebServerClient varchar(100) null,-----登录时所用的浏览器类型
		Remark varchar(100) null-----备注
         */
        private int logLoginId;
        private Users user;
        private DateTime logLoginTime;
        private DateTime logLogoutTime;
        private string logLoginIp;
        private string logLoginOperatiionSystem;
        private string logLoginWebServerClient;
        private string remark;
        public int LogLoginId { get => logLoginId; set => logLoginId = value; }
        public DateTime LogLoginTime { get => logLoginTime; set => logLoginTime = value; }
        public DateTime LogLogoutTime { get => logLogoutTime; set => logLogoutTime = value; }
        public string LogLoginIp { get => logLoginIp; set => logLoginIp = value; }
        public string LogLoginOperatiionSystem { get => logLoginOperatiionSystem; set => logLoginOperatiionSystem = value; }
        public string LogLoginWebServerClient { get => logLoginWebServerClient; set => logLoginWebServerClient = value; }
        public string Remark { get => remark; set => remark = value; }
        public Users User { get => user; set => user = value; }
    }
}

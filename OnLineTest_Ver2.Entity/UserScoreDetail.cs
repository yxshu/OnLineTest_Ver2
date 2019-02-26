using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class UserScoreDetail
    {
        /*
		UserScoreDetailId int identity(1,1) primary key,-----ID
		UserId int not null foreign key references Users(UserID),-----用户ID
		UserAuthorityId int not null foreign key references UserAuthority(UserAuthorityId),-----用户权限，可以理解为执行的操作，可以根据每个操作的得分值判断得分情况
		UserScoreDetailTime datetime not null default getdate()-----执行操作的时间
         */
        private int userScoreDetailId;
        private Users users;
        private UserAuthority userAuthority;
        private DateTime userScoreDetailTime;

        public int UserScoreDetailId { get => userScoreDetailId; set => userScoreDetailId = value; }
        public DateTime UserScoreDetailTime { get => userScoreDetailTime; set => userScoreDetailTime = value; }
        public Users Users { get => users; set => users = value; }
        public UserAuthority UserAuthority { get => userAuthority; set => userAuthority = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
   public class UserAuthority
    {
        /*
		UserAuthorityId int identity(1,1) primary key,-----用户权限ID
		AuthorityId int  not null foreign key references Authority(AuthorityId),-----外键，用户权限
		UserGroupId int not null foreign key references UserGroup(UserGroupId),-----用户权限所对应的用户组
		UserRankId int not null foreign key references UserRank(UserRankId), -----此权限所对应的用户等级（外键）
		UserAuthoriryRemark varchar(max),-----用户权限备注
         */
        private int userAuthorityId;
        private Authority authority;
        private UserGroup userGroup;
        private UserRank userRank;
        private string userAuthoriryRemark;

        public int UserAuthorityId { get => userAuthorityId; set => userAuthorityId = value; }
        public string UserAuthoriryRemark { get => userAuthoriryRemark; set => userAuthoriryRemark = value; }
        public Authority Authority { get => authority; set => authority = value; }
        public UserGroup UserGroup { get => userGroup; set => userGroup = value; }
        public UserRank UserRank { get => userRank; set => userRank = value; }
    }
}

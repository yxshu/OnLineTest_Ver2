using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
   public class UserGroup
    {
        /*
		UserGroupId int identity(1,1) primary key,--用户组Id int identity primary key
		UserGroupName varchar(50) not null unique,--用户组名称 varchar(20) unique
		UserGroupRemark varchar(max),--用户组备注
    */
        private int userGroupId;
        private string userGroupName;
        private string userGroupRemark;

        public int UserGroupId { get => userGroupId; set => userGroupId = value; }
        public string UserGroupName { get => userGroupName; set => userGroupName = value; }
        public string UserGroupRemark { get => userGroupRemark; set => userGroupRemark = value; }
    }
}

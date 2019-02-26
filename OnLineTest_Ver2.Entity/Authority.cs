using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class Authority
    {
        /*
		AuthorityId int identity(1,1) primary key,-----权限ID
		AuthorityName varchar(50) not null,-----此项权限的中文名称
		AuthorityScore int  not null,-----此项权限（动作）所对应的分值(可以为负值)
		AuthorityHandlerPage varchar(50) not null unique,-----此项权限的处理页面
		AuthorityOrderNum int default 0,-------此项权限的排序号
		AuthorityRemark varchar(max),-----此项权限所的备注
         */
        private int authorityId;
        private string authorityName;
        private int authorityScore;
        private string authorityHandlerPage;
        private int authorityOrderNum;
        private string authorityRemark;

        public int AuthorityId { get => authorityId; set => authorityId = value; }
        public string AuthorityName { get => authorityName; set => authorityName = value; }
        public int AuthorityScore { get => authorityScore; set => authorityScore = value; }
        public string AuthorityHandlerPage { get => authorityHandlerPage; set => authorityHandlerPage = value; }
        public int AuthorityOrderNum { get => authorityOrderNum; set => authorityOrderNum = value; }
        public string AuthorityRemark { get => authorityRemark; set => authorityRemark = value; }
    }
}

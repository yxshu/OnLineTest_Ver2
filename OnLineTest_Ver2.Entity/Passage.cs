using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class Passage
    {
        /*
	PassageId int identity(1,1)  primary key,
	PassageContent varchar(max) not null,
	PassageRemark varchar(max)
         */
        private int passageId;
        private string passageContent;
        private string passageRemark;

        public int PassageId { get => passageId; set => passageId = value; }
        public string PassageContent { get => passageContent; set => passageContent = value; }
        public string PassageRemark { get => passageRemark; set => passageRemark = value; }
    }
}

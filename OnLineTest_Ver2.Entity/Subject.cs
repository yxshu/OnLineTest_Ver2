using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class Subject
    {
        /*
		SubjectId int identity(1,1) primary key,-----科目ID
		SubjectName varchar(50) not null,-----科目名称
		SubjectRemark varchar(max),-----科目备注
         */
        private int subjectId;
        private string subjectName;
        private string subjectRemark;

        public int SubjectId { get => subjectId; set => subjectId = value; }
        public string SubjectName { get => subjectName; set => subjectName = value; }
        public string SubjectRemark { get => subjectRemark; set => subjectRemark = value; }
    }
}

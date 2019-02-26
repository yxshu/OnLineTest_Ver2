using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class ExamZone
    {
        /*
		ExamZoneId int identity(1,1) primary key,-----ID
		ExamZoneName nvarchar(20) not null,-----考区名称
        ExamZoneRemark varchar(max)
         */
        private int examZoneId;
        private string examZoneName;
        private string examZoneRemark;

        public int ExamZoneId { get => examZoneId; set => examZoneId = value; }
        public string ExamZoneName { get => examZoneName; set => examZoneName = value; }
        public string ExamZoneRemark { get => examZoneRemark; set => examZoneRemark = value; }
    }
}

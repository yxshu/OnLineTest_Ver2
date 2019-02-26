using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class StationMail
    {
        /*
		StationMailId int identity(1,1) primary key,-----ID
		StationMailParentId int,-----如果是回复的话,标明回复哪一条站内信
		StationMailTO int not null foreign key references Users(UserId),-----收信人
		StationMailFrom int not null foreign key references Users(UserId),-----发信人
		StationMailContent varchar(max) not null,-----站内信内容
		StationMailSendTime datetime default getdate(),-----发信时间
		StationMailIsReaded bit not null default 0,-----是否阅读
		StationMailReadTime datetime,-- check(if(MessageIsRead==1)MessageReadTime not null),-----阅读时间
         */
        private int stationMailId;
        private StationMail stationMailParent;
        private Users stationMailTO;
        private Users stationMailFrom;
        private string stationMailContent;
        private DateTime stationMailSendTime;
        private bool stationMailIsReaded;
        private DateTime stationMailReadTime;

        public int StationMailId { get => stationMailId; set => stationMailId = value; }
        public string StationMailContent { get => stationMailContent; set => stationMailContent = value; }
        public DateTime StationMailSendTime { get => stationMailSendTime; set => stationMailSendTime = value; }
        public bool StationMailIsReaded { get => stationMailIsReaded; set => stationMailIsReaded = value; }
        public DateTime StationMailReadTime { get => stationMailReadTime; set => stationMailReadTime = value; }
        public StationMail StationMailParent { get => stationMailParent; set => stationMailParent = value; }
        public Users StationMailTO { get => stationMailTO; set => stationMailTO = value; }
        public Users StationMailFrom { get => stationMailFrom; set => stationMailFrom = value; }
    }
}

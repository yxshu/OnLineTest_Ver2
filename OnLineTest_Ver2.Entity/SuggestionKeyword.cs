using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class SuggestionKeyword
    {
        /*
		SuggestionKeywordId int identity(1,1) primary key,-----ID
		SuggestionKeyword varchar(200) not null,-----热词//这里要注意长度的问题,varchar100,只能存50个字符,nvarchar100可以存100个
		SuggestionKeywordCreateTime datetime not null default getdate(),-----创建时间
		SuggestionKeywordNum int not null-----搜索次数
         */
        private int suggestionKeywordId;
        private string keyword;
        private DateTime suggestionKeywordCreateTime;
        private int suggestionKeywordNum;

        public int SuggestionKeywordId { get => suggestionKeywordId; set => suggestionKeywordId = value; }
        public string Keyword { get => keyword; set => keyword = value; }
        public DateTime SuggestionKeywordCreateTime { get => suggestionKeywordCreateTime; set => suggestionKeywordCreateTime = value; }
        public int SuggestionKeywordNum { get => suggestionKeywordNum; set => suggestionKeywordNum = value; }
    }
}

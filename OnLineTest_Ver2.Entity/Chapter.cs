using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineTest_Ver2.Entity
{
    public class Chapter
    {
        /*

		ChapterId int identity(1,1) primary key,-----章节ID
		ChapterName varchar(200) not null,-----章节名称
		ChapterParentNo int,-----父节点编号
		ChapterOrder int not null,----章节排序
		ChapterRemark varchar(max),-----备注
         */
        private int chapterId;
        private string chapterName;
        private Chapter chapterParentNo;
        private int chapterOrder;
        private string chapterRemark;

        public int ChapterId { get => chapterId; set => chapterId = value; }
        public string ChapterName { get => chapterName; set => chapterName = value; }
        public int ChapterOrder { get => chapterOrder; set => chapterOrder = value; }
        public string ChapterRemark { get => chapterRemark; set => chapterRemark = value; }
        internal Chapter ChapterParentNo { get => chapterParentNo; set => chapterParentNo = value; }
    }
}

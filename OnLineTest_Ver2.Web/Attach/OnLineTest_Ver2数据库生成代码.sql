
------------------------------------------------ �������ݿⲿ�� ------------------------------------------------


use master -- ���õ�ǰ���ݿ�Ϊmaster,�Ա����sysdatabases��
declare @OnLineTest varchar(20);
  set @OnLineTest='OnLineTest_Ver2';
if exists(select * from sysdatabases where name=@OnLineTest) 
drop database OnLineTest_Ver2;      
CREATE DATABASE OnLineTest_Ver2 ON  PRIMARY 
(
	 NAME = N'OnLineTest_Ver2', 
	 FILENAME = N'D:\OnLineTest_Ver2.mdf' , 
	 SIZE = 10240KB , 
	 FILEGROWTH = 1024KB 
 )
 LOG ON 
( 
	NAME = N'OnLineTest_Ver2_log', 
	FILENAME = N'D:\OnLineTest_Ver2_log.ldf' , 
	SIZE = 1024KB , 
	FILEGROWTH = 10%
)
use OnLineTest_Ver2
------------------------------------------------�������ݱ���----------------------------------------------

------------------------------------------------ �����û����UserGroup�� ------------------------------------------------

if exists (select * from sysobjects where name='UserGroup')
drop table UserGroup
	CREATE TABLE UserGroup --�û���
	(
		UserGroupId int identity(1,1) primary key,--�û���Id int identity primary key
		UserGroupName varchar(50) not null unique,--�û������� varchar(20) unique
		UserGroupRemark varchar(max),--�û��鱸ע
	)
------------------------------------------------ �����û��ȼ���UserRank��,�����û��ĵ÷֣�UserScore�������û��ĵȼ� ------------------------------------------------

if exists (select*from sysobjects where name='UserRank')
drop table UserRank
	create table UserRank-----�û��ȼ���
	(
		UserRankId int identity(1,1) primary key,-----�ȼ�ID
		UserRankName varchar(50) not null unique,-----�ȼ���Ӧ����������
		MinScore int not null check(MinScore>=0),-----�ȼ�����Ӧ����ͷ�
		MaxScore int not null check(MaxScore>=0),-----�ȼ�����Ӧ����߷�
	)


------------------------------------------------ �����û���Users,user�ǹؼ��֣�������users�� ------------------------------------------------

if exists (select*from sysobjects where name='Users')
drop table Users
	CREATE TABLE Users
	(
		UserId int identity(1,1) primary key,-----�û�ID��
		UserName varchar(50) not null unique,-----��¼��
		UserPassword varchar(200) not null,----��¼���룬Ҫ��ʹ��MD5��ʽ�洢
		UserChineseName varchar(50) not null default '-',------�û�����
		UserImagePath varchar(200) not null default('default.jpg'),
		UserEmail varchar(50) not null unique,-----�û������ʼ�
		IsValidate bit not null default 0,-----�Ƿ�ͨ�������ʼ���֤
		Tel varchar(20) null,
		UserScore int not null default 0 ,-----�û�����̳��ֵ
		UserRegisterDatetime datetime not null default getdate(),-----�û�ע��ʱ��
		UserLoginStatus bit not null default 0,------�û��Ƿ��¼���0Ϊδ��¼,1Ϊ��¼
		UserGroupId int not null default(1) foreign key references UserGroup(UserGroupId),
	)
GO
------------------------------------------------ ����Ȩ�ޱ�Authority�� ------------------------------------------------

if exists (select*from sysobjects where name='Authority')
drop table Authority
	create table Authority-----Ȩ�ޱ�
	(
		AuthorityId int identity(1,1) primary key,-----Ȩ��ID
		AuthorityName varchar(50) not null,-----����Ȩ�޵���������
		AuthorityScore int  not null,-----����Ȩ�ޣ�����������Ӧ�ķ�ֵ(����Ϊ��ֵ)
		AuthorityHandlerPage varchar(50) not null unique,-----����Ȩ�޵Ĵ���ҳ��
		AuthorityOrderNum int default 0,-------����Ȩ�޵������
		AuthorityRemark varchar(max),-----����Ȩ�����ı�ע
	)
GO
  
------------------------------------------------ �����û�Ȩ�ޱ�UserAuthority�� ------------------------------------------------   
    
if exists (select*from sysobjects where name='UserAuthority')
drop table UserAuthority
	create table UserAuthority-----�û�Ȩ�ޱ�
	(
		UserAuthorityId int identity(1,1) primary key,-----�û�Ȩ��ID
		AuthorityId int  not null foreign key references Authority(AuthorityId),-----������û�Ȩ��
		UserGroupId int not null foreign key references UserGroup(UserGroupId),-----�û�Ȩ������Ӧ���û���
		UserRankId int not null foreign key references UserRank(UserRankId), -----��Ȩ������Ӧ���û��ȼ��������
		UserAuthoriryRemark varchar(max),-----�û�Ȩ�ޱ�ע
	)
GO

------------------------------------------------ ���ɵ÷���ϸ��UserScoreDetail�� ------------------------------------------------

if exists (select*from sysobjects where name='UserScoreDetail')
drop table UserScoreDetail
create table UserScoreDetail-----�û��÷ֵ���ϸ��¼
	(
		UserScoreDetailId int identity(1,1) primary key,-----ID
		UserId int not null foreign key references Users(UserID),-----�û�ID
		UserAuthorityId int not null foreign key references UserAuthority(UserAuthorityId),-----�û�Ȩ�ޣ��������Ϊִ�еĲ��������Ը���ÿ�������ĵ÷�ֵ�жϵ÷����
		UserScoreDetailTime datetime not null default getdate()-----ִ�в�����ʱ��
	)
GO

------------------------------------------------ ����վ���ű�(StationMail) ------------------------------------------------

if exists (select*from sysobjects where name='StationMail')
drop table StationMail
create table StationMail-----վ����
	(
		StationMailId int identity(1,1) primary key,-----ID
		StationMailParentId int,-----����ǻظ��Ļ�,�����ظ���һ��վ����
		StationMailTO int not null foreign key references Users(UserId),-----������
		StationMailFrom int not null foreign key references Users(UserId),-----������
		StationMailContent varchar(max) not null,-----վ��������
		StationMailSendTime datetime default getdate(),-----����ʱ��
		StationMailIsReaded bit not null default 0,-----�Ƿ��Ķ�
		StationMailReadTime datetime,-- check(if(MessageIsRead==1)MessageReadTime not null),-----�Ķ�ʱ��
	)
GO
------------------------------------------------ ���ɲ㼶��Level�� ------------------------------------------------

if exists (select*from sysobjects where name='Level')
drop table Level
	create table Level-----�Ծ����㼶��
	(
	LevelId int identity(1,1) primary key,
	LevelName varchar(50) not null,---�㼶˵���������������󸱣�������
	LevelRemark varchar(max),
	)

GO

------------------------------------------------ ���ɿ�Ŀ�� ------------------------------------------------
           
if exists (select*from sysobjects where name='Subject')
drop table Subject
	create table Subject-----���ÿ�Ŀ��
	(
		SubjectId int identity(1,1) primary key,-----��ĿID
		SubjectName varchar(50) not null,-----��Ŀ����
		SubjectRemark varchar(max),-----��Ŀ��ע
	)
------------------------------------------------ �����Ծ�����PaperCode�� ------------------------------------------------

if exists (select*from sysobjects where name='PaperCode')
drop table PaperCode
	create table PaperCode-----�Ծ�����
	(
		PaperCodeId int identity(1,1) primary key,-----�Ծ����ID
		LevelId int not null foreign key references Level(LevelId),---�㼶
		SubjectId int not null foreign key references Subject(SubjectId),-----�Ծ��������Ӧ�Ŀ�ĿID�����
		Code int not null unique,-----�Ծ����
		ChineseName varchar(200) not null,-----�Ծ��������Ӧ����������
		PaperCodePassScore int not null check(PaperCodePassScore>0),-----�Ծ����ļ��������
		PaperCodeTotalScore int not null, ---check(PaperCodeTotalScore>PaperCodePassScore),-----�Ծ������ܷ�
		TimeRange int not null check(TimeRange>0),-----�Ծ���뿼�Ե�ʱ��
		PaperCodeRemark varchar(max) null,-----�Ծ����ı�ע
		constraint PaperCodeTotalScore_PaperCodePassScore_check check(PaperCodeTotalScore>PaperCodePassScore)
	)
GO

------------------------------------------------ �����½ڱ�Chapter�� ------------------------------------------------

if exists (select*from sysobjects where name='Chapter')
drop table Chapter
create table Chapter------�̲�����Ӧ���½ڱ�
	(
		ChapterId int identity(1,1) primary key,-----�½�ID
		ChapterName varchar(200) not null,-----�½�����
		ChapterParentNo int,-----���ڵ���
		ChapterOrder int not null,----�½�����
		ChapterRemark varchar(max),-----��ע
	)
GO
------------------------------------------------ ���ɽ�ѧ��ٱ�Syllabus�� ------------------------------------------------

if exists (select*from sysobjects where name='Syllabus')
drop table Syllabus
create table Syllabus------��ѧ��٣����㼶����Ŀ��Ӧ���½ڹ�ϵ
	(
	SyllabusId int identity(1,1) primary key,
	PaperCodeId int not null foreign key references PaperCode(PaperCodeId),
	ChapterId int not null foreign key references Chapter(ChapterId),
	SyllabusRemark varchar(max)
	)
GO

------------------------------------------------ ���ɿ�����Ϣ��ExamZone�� ------------------------------------------------

if exists (select*from sysobjects where name='ExamZone')
drop table ExamZone
create table ExamZone-----������Ϣ
	(
		ExamZoneId int identity(1,1) primary key,-----ID
		ExamZoneName nvarchar(20) not null,-----��������
		ExamZoneRemark varchar(max)
	)
GO

------------------------------------------------ ����������Ϣ��PastExamPaper�� ------------------------------------------------

if exists (select*from sysobjects where name='PastExamPaper')
drop table PastExamPaper
create table PastExamPaper-----����������Ϣ�����ﲻ����������Ϣ��
	(
		PastExamPaperId int identity(1,1) primary key,-----ID
		ExamZoneId int not null foreign key references ExamZone(ExamZoneId),-----�����Ӧ�Ŀ�����Ϣ
		PaperCodeId int not null foreign key references PaperCode(PaperCodeId),-----�����Ӧ���Ծ����
		PastExamPaperPeriodNo int not null,-----����
		PastExamPaperDatetime datetime not null,-----���Ե�ʱ��
	)
GO

------------------------------------------------ ���������ȴʱ�SuggestionKeyword�� ------------------------------------------------

if exists (select*from sysobjects where name='SuggestionKeyword')
drop table SuggestionKeyword
create table SuggestionKeyword-----�������ȴ�
	(
		SuggestionKeywordId int identity(1,1) primary key,-----ID
		Keyword varchar(200) not null,-----�ȴ�//����Ҫע�ⳤ�ȵ�����,varchar100,ֻ�ܴ�50���ַ�,nvarchar100���Դ�100��
		SuggestionKeywordCreateTime datetime not null default getdate(),-----����ʱ��
		SuggestionKeywordNum int not null-----��������
	)
GO

------------------------------------------------ �����������ͱ�QuestionType,����������һ��ö�����ͣ� ------------------------------------------------

if exists (select*from sysobjects where name='QuestionType')
drop table QuestionType
create table QuestionType-----��������
	(
	QuestionTypeId int identity(1,1) primary key,
	QuestionTypeDescrip varchar(20) not null,
	QuestionTypeRemark varchar(max)
	)
GO

------------------------------------------------ ���������Ѷ�ϵ����Difficulty�� ------------------------------------------------

if exists (select*from sysobjects where name='Difficulty')
drop table Difficulty
create table Difficulty-----������Ѷ�ϵ��
	(
		DifficultyId int identity(1,1) primary key,-----�Ѷ�ϵ��ID
		DifficultyRatio int not null default 0 check( DifficultyRatio>=0 and DifficultyRatio<=10),-----�Ѷ�ϵ��0-10
		DifficultyDescrip varchar(50) not null,-----�Ѷ�ϵ����Ӧ������
		DifficultyRemark varchar(max)-----��ע
	)
GO

------------------------------------------------ ����Ӣ���е�passage�����Ӧ�Ķ��ģ�Passage�� ------------------------------------------------

if exists (select*from sysobjects where name='Passage')
drop table Passage
create table Passage-----passage�����Ӧ�Ķ���
	(
	PassageId int identity(1,1)  primary key,
	PassageContent varchar(max) not null,
	PassageRemark varchar(max)
	)
GO

------------------------------------------------ QuestionFORGeneral����Ĺ��ԣ�QuestionFORGeneral�� ------------------------------------------------

if exists (select*from sysobjects where name='QuestionFORGeneral')
drop table QuestionFORGeneral
create table QuestionFORGeneral----- QuestionFORGeneral����Ĺ���
	(
		QuestionId int identity(1,1) primary key,-----����ID
		QuestionType int not null foreign key references QuestionType(QuestionTypeId),----���������
		QuestionTitle varchar(max) not null,-----��Ŀ
		Explain varchar(max),-----����
		ImagePath varchar(200),-----ͼ������
		DifficultyId int not null references Difficulty(DifficultyId),-----�Ѷ�ϵ��
		UserId int not null references Users(UserId),-----�ϴ���ID
		UpLoadTime datetime not null default getdate(),-----�ϴ�ʱ��
		VerifyTimes int not null default 0,-----����˴���������������Ч��
		IsDelte bit not null default 0,-----��ɾ�����
		IsSupported int not null default 0,-----���޴���
		IsDeSupported int not null default 0,-----���ȴ���
		PaperCodeId int not null references PaperCode(PaperCodeId),-----��������Ӧ���Ծ����
		ChapterId int not null references Chapter(ChapterId),-----��������Ӧ���½�
		PastExamPaperId int references PastExamPaper(PastExamPaperId),-----�����Ƿ�����������
		PastExamQuestionId int, -----��������⣬���������е����
		Remark varchar(max) ---------��ע
	)
GO

------------------------------------------------ QuestionFORPanduan�ж��⣨QuestionFORPanduan�� ------------------------------------------------

if exists (select*from sysobjects where name='QuestionFORPanduan')
drop table QuestionFORPanduan
create table QuestionFORPanduan----- QuestionFORPanduan�ж���
	(
	QuestionFORPanduanId int identity(1,1) primary key,
	QuestionFORGeneralId int not null foreign key references QuestionFORGeneral(QuestionId),
	CorrectAnswer bit  not null
	)
GO

------------------------------------------------ QuestionFORDanxuan��ѡ�⣨QuestionFORDanxuan�� ------------------------------------------------

if exists (select*from sysobjects where name='QuestionFORDanxuan')
drop table QuestionFORDanxuan
create table QuestionFORDanxuan----- QuestionFORDanxuan��ѡ��
	(
	QuestionFORDanxuanId int identity(1,1) primary key,
	QuestionFORGeneralId int not null foreign key references QuestionFORGeneral(QuestionId),
	AnswerA varchar(max)  not null,
	AnswerB varchar(max)  not null,
	AnswerC varchar(max)  not null,
	AnswerD varchar(max)  not null,
	CorrectAnswer int  not null check(CorrectAnswer in(1,2,3,4))
	)
GO

------------------------------------------------ QuestionFORPassageӢ���е�passage���⣨QuestionFORPassage�� ------------------------------------------------

if exists (select*from sysobjects where name='QuestionFORPassage')
drop table QuestionFORPassage
create table QuestionFORPassage----- QuestionFORPassageӢ���е�passage����
	(
	QuestionFORPassageId int identity(1,1) primary key,
	QuestionFORDanxuanId int not null foreign key references QuestionFORDanxuan(QuestionFORDanxuanId),
	PassageId int references Passage(PassageId)
	)
------------------------------------------------ �����������״̬��VerifyStatus�� ------------------------------------------------

if exists (select*from sysobjects where name='VerifyStatus')
drop table VerifyStatus
create table VerifyStatus-----��˹����еĸ���״̬
	(
		VerifyStatusId int identity(1,1) primary key,-----���״̬ID
		QuestionId int not null references QuestionFORGeneral(QuestionId),-----��������ж�Ӧ������ID��Ҫ���ͨ���Ժ���ܸ��µ�����⣩
		UserId int not null references Users(UserId),-----�����ID
		Stamp bit not null default 0,-----�Ƿ�ͨ�����
		VerifyTime datetime not null default getdate(),-----���ʱ��
		NewQuestinId int foreign key references  QuestionFORGeneral(QuestionId),
		Remark varchar(max)
	)
GO

------------------------------------------------ �����������۱�Comment�� ------------------------------------------------

if exists (select*from sysobjects where name='Comment')
drop table Comment
create table Comment-----�����û������������
	(
		CommentId int identity(1,1) primary key,-----ID
		QuestionId int not null references QuestionFORGeneral(QuestionId),-----��� ����ID
		UserId int not null references Users(UserId),-----��� �û�ID
		CommentContent text not null,-----���۵�����
		CommentTime datetime not null default getdate(),-----�������۵�ʱ��
		QuoteCommentId int null references Comment(CommentId),-----���õ�����
		IsDeleted bit not null default 0,-----�Ƿ�ɾ��	
		DeleteUserId int null references Users(UserId),-----��� ɾ��������
		DeleteCommentTime datetime null -----ɾ������ʱ��
	)
GO

------------------------------------------------ ����UserCreatePaper�û��������Ծ� ------------------------------------------------

if exists (select*from sysobjects where name='UserCreatePaper')
drop table UserCreatePaper
create table UserCreatePaper-----���ڱ����û������Ծ���Ϣ��������������Ϣ��
	(
		UserCreatePaperId int identity(1,1) primary key,-----ID
		UserId int not null references Users(UserId),-----�û�ID
		PaperCodeId int not null references PaperCode(PaperCodeId),-----�Ծ����Id
		DifficultyId int not null references Difficulty(DifficultyId),-----�Ѷ�ϵ��
		UserCreatePaperTime datetime not null default getdate()-----����ʱ��
	)
GO

------------------------------------------------ ����UserCreatePaperQuestion�û������Ծ��ڰ��������� ------------------------------------------------

if exists (select*from sysobjects where name='UserCreatePaperQuestione')
drop table UserCreatePaperQuestione
create table UserCreatePaperQuestione-----�����û������Ծ���Ϣ������������Ϣ��
	(
		UserCreatePaperQuestioneId int identity(1,1) primary key,-----ID
		UserCreatePaperId int not null references UserCreatePaper(UserCreatePaperId),-----�Ծ���ϢID
		QuestionId int not null references QuestionFORGeneral(QuestionId)-----����ID
	)
GO

------------------------------------------------ ������ϰ��¼��LogPractice�� ------------------------------------------------

if exists (select*from sysobjects where name='LogPractice')
drop table LogPractice
create table LogPractice-----������ϰ��ϰ��
	(
		LogPracticeId int identity(1,1) primary key,-----ID
		UserId int not null references Users(UserId),-----�û�ID
		QuestionId int not null references QuestionFORGeneral(QuestionId),-----����ID
		LogPracticeTime datetime not null default getdate(),-----��ϰʱ��
		LogPracticeAnswer int,-----��ϰʱ�����Ĵ�
		LogPracetimeRemark text null-----��ע
	)
GO

------------------------------------------------ ���ɲ��Լ�¼��LogTest�� ------------------------------------------------

if exists (select*from sysobjects where name='LogTest')
drop table LogTest
create table LogTest-----����ƽʱ������Ϣ���������������⣩
	(
		LogTestId int identity(1,1) primary key,-----ID
		UserId int not null references Users(UserId),-----�û�ID
		UserCreatePaperId int not null foreign key references UserCreatePaper(UserCreatePaperId),---��һ���Ծ�
		LogTestStartTime datetime not null default getdate(),-----����ʱ��
        LogTestEndTime datetime null,		
		LogTestScore int not null default 0-----���Եĵ÷֣�Ĭ��Ϊ0��
	)
GO

------------------------------------------------ ���ɲ����û��𰸱� ------------------------------------------------

if exists (select*from sysobjects where name='LogTestUserAnswer')
drop table LogTestUserAnswer
create table LogTestUserAnswer-----����ƽʱ������Ϣ������������Ϣ��
	(
		LogTestUserAnswerId int identity(1,1) primary key,-----ID
		LogTestId int not null references LogTest(LogTestId),-----��� ������ϢID
		QuestionId int not null references QuestionFORGeneral(QuestionId),-----��� ����ID
		UserAnswer int,-----����ʱ�����Ĵ�
		LogTestUserAnswerRemark varchar(max)-----��ע
	)
GO

------------------------------------------------ �����û���¼��¼�� ------------------------------------------------

if exists (select*from sysobjects where name='LogLogin')
drop table LogLogin
create table LogLogin-----��¼��¼
	(
		LogLoginId int identity(1,1) primary key,-----ID
		UserId int not null references Users(UserID),-----�û�ID
		LogLoginTime datetime not null default getdate(),-----��¼ʱ��
		LogLogoutTime datetime,-----�ǳ�ʱ��
		LogLoginIp varchar(20) not null default('127.0.0.1'),-----��¼IP
		LogLoginOperatiionSystem nvarchar(200) null,-----��¼ʱ���õĲ���ϵͳ
		LogLoginWebServerClient varchar(100) null,-----��¼ʱ���õ����������
		Remark varchar(100) null-----��ע
	)
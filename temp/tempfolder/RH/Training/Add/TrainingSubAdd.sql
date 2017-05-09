/*
  RH_TrainingSub - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingSub_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingSub_Add
(
   IN i_TID int,
   IN i_TName nvarchar(200),
   IN i_TrainingNum int,
   IN i_TrainingLevelCode varchar(50),
   IN i_TrainingTypeCode varchar(50),
   IN i_TMethod int,
   IN i_IsGP int,
   IN i_OrgCode varchar(50),
   IN i_TrainingDateB datetime,
   IN i_TrainingDateE datetime,
   IN i_SignupRule int,
   IN i_ClassRule nchar(10),
   IN i_IsStage int,
   IN i_TrainingUrl varchar(200),
   IN i_TrainingHeadImg varchar(200),
   IN i_StaticUrl nvarchar(200),
   IN i_Status int,
   IN i_AskTel varchar(50),
   IN i_IsShowQQ int,
   IN i_TestMethod int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   IN i_Publisher int,
   IN i_PublishDate datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingSub
  (
      TID,
      TName,
      TrainingNum,
      TrainingLevelCode,
      TrainingTypeCode,
      TMethod,
      IsGP,
      OrgCode,
      TrainingDateB,
      TrainingDateE,
      SignupRule,
      ClassRule,
      IsStage,
      TrainingUrl,
      TrainingHeadImg,
      StaticUrl,
      Status,
      AskTel,
      IsShowQQ,
      TestMethod,
      CreateBy,
      CreateTime,
      UpdateBy,
      UpdateTime,
      Publisher,
      PublishDate
  )
  VALUES
  (
      i_TID,  --  int (主项目ID)
      i_TName,  --  nvarchar(200) (项目名称)
      i_TrainingNum,  --  int (项目名称)
      i_TrainingLevelCode,  --  varchar(50) (承担机构id 对应表FJ_TrainingOrg的ID)
      i_TrainingTypeCode,  --  varchar(50) (TrainingTypeCode)
      i_TMethod,  --  int (研修方式：1.网络培训 2.现场培训 3.能力提升)
      i_IsGP,  --  int (是否国培 1 是 2 否)
      i_OrgCode,  --  varchar(50) (OrgCode)
      i_TrainingDateB,  --  datetime (时间安排起)
      i_TrainingDateE,  --  datetime (时间安排止)
      i_SignupRule,  --  int (报名规则：1.导入报名 2.自主报名)
      i_ClassRule,  --  nchar(10) (分班规则：1.规则分班 2.人工分班)
      i_IsStage,  --  int (是否阶段项目 1 是 2 否)
      i_TrainingUrl,  --  varchar(200) (TrainingUrl)
      i_TrainingHeadImg,  --  varchar(200) (TrainingHeadImg)
      i_StaticUrl,  --  nvarchar(200) (StaticUrl)
      i_Status,  --  int (1.待实施(对应动作填写实施方案) 2.待配课（对应动作申请配课） 3.配课中（对应动作配课完成） 4.待发布（对应动作发布） 5.已发布 6.删除)
      i_AskTel,  --  varchar(50) (咨询电话)
      i_IsShowQQ,  --  int (是否显示在线客服 1 是 2 否)
      i_TestMethod,  --  int (测评工具 1内部 2外部)
      i_CreateBy,  --  int (创建人)
      i_CreateTime,  --  datetime (创建时间)
      i_UpdateBy,  --  int (更新人)
      i_UpdateTime,  --  datetime (更新时间)
      i_Publisher,  --  int (发布人)
      i_PublishDate  --  datetime (发布时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

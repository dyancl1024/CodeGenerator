/*
  RH_TrainingSub - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingSub_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingSub_Modify
(
   IN i_ID int,
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

  UPDATE RH_TrainingSub
  SET
      TID = i_TID,
      TName = i_TName,
      TrainingNum = i_TrainingNum,
      TrainingLevelCode = i_TrainingLevelCode,
      TrainingTypeCode = i_TrainingTypeCode,
      TMethod = i_TMethod,
      IsGP = i_IsGP,
      OrgCode = i_OrgCode,
      TrainingDateB = i_TrainingDateB,
      TrainingDateE = i_TrainingDateE,
      SignupRule = i_SignupRule,
      ClassRule = i_ClassRule,
      IsStage = i_IsStage,
      TrainingUrl = i_TrainingUrl,
      TrainingHeadImg = i_TrainingHeadImg,
      StaticUrl = i_StaticUrl,
      Status = i_Status,
      AskTel = i_AskTel,
      IsShowQQ = i_IsShowQQ,
      TestMethod = i_TestMethod,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime,
      Publisher = i_Publisher,
      PublishDate = i_PublishDate
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

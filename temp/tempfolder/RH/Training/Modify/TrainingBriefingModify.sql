/*
  RH_TrainingBriefing - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingBriefing_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingBriefing_Modify
(
   IN i_ID int,
   IN i_ObjectID int,
   IN i_MType int,
   IN i_Periods nvarchar(50),
   IN i_Title nvarchar(200),
   IN i_BContnet nvarchar(Max),
   IN i_ClickNum int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   IN i_StaticUrl nvarchar(200),
   OUT o_Result int
)
BEGIN

  UPDATE RH_TrainingBriefing
  SET
      ObjectID = i_ObjectID,
      MType = i_MType,
      Periods = i_Periods,
      Title = i_Title,
      BContnet = i_BContnet,
      ClickNum = i_ClickNum,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime,
      StaticUrl = i_StaticUrl
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

/*
  RH_TrainingOther - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingOther_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingOther_Modify
(
   IN i_ID int,
   IN i_TID int,
   IN i_SubTID int,
   IN i_TTitle nvarchar(50),
   IN i_TType int,
   IN i_TContent nvarchar(Max),
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_TrainingOther
  SET
      TID = i_TID,
      SubTID = i_SubTID,
      TTitle = i_TTitle,
      TType = i_TType,
      TContent = i_TContent,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

/*
  RH_TrainingMyHomeWork - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingMyHomeWork_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingMyHomeWork_Modify
(
   IN i_ID int,
   IN i_HomeWorkTitle nvarchar(50),
   IN i_HomeWorkContent nvarchar(Max),
   IN i_HomeWorkPhaseID int,
   IN i_SubTID int,
   IN i_Status int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_TrainingMyHomeWork
  SET
      HomeWorkTitle = i_HomeWorkTitle,
      HomeWorkContent = i_HomeWorkContent,
      HomeWorkPhaseID = i_HomeWorkPhaseID,
      SubTID = i_SubTID,
      Status = i_Status,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

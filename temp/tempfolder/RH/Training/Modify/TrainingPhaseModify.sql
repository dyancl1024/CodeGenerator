/*
  RH_TrainingPhase - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingPhase_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingPhase_Modify
(
   IN i_ID int,
   IN i_SubTID int,
   IN i_PType int,
   IN i_HomeName nvarchar(50),
   IN i_HomeWorkDesc nvarchar(200),
   IN i_HomeWorkCode varchar(50),
   IN i_Phase int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_TrainingPhase
  SET
      SubTID = i_SubTID,
      PType = i_PType,
      HomeName = i_HomeName,
      HomeWorkDesc = i_HomeWorkDesc,
      HomeWorkCode = i_HomeWorkCode,
      Phase = i_Phase,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

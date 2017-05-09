/*
  RH_TrainingExcellent - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingExcellent_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingExcellent_Modify
(
   IN i_ID int,
   IN i_TID int,
   IN i_UserID int,
   IN i_Ttype int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_TrainingExcellent
  SET
      TID = i_TID,
      UserID = i_UserID,
      Ttype = i_Ttype,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

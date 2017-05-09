/*
  RH_TrainingClassUserRelation - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingClassUserRelation_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingClassUserRelation_Modify
(
   IN i_ID int,
   IN i_UserID int,
   IN i_ClassID int,
   IN i_SubTID int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_TrainingClassUserRelation
  SET
      UserID = i_UserID,
      ClassID = i_ClassID,
      SubTID = i_SubTID,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

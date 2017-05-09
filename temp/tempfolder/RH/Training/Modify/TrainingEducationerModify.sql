/*
  RH_TrainingEducationer - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingEducationer_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingEducationer_Modify
(
   IN i_ID int,
   IN i_DesignID int,
   IN i_UserID int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_TrainingEducationer
  SET
      DesignID = i_DesignID,
      UserID = i_UserID,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

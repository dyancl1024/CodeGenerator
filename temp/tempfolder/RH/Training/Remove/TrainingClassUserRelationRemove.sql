/*
  RH_TrainingClassUserRelation - 删除信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingClassUserRelation_Remove;
CREATE  PROCEDURE sp_SJ_RH_TrainingClassUserRelation_Remove
(
   IN i_ID int,
   OUT o_Result int
)
BEGIN

  DELETE FROM RH_TrainingClassUserRelation WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

/*
  RH_TrainingSubSubject - 删除信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingSubSubject_Remove;
CREATE  PROCEDURE sp_SJ_RH_TrainingSubSubject_Remove
(
   IN i_ID int,
   OUT o_Result int
)
BEGIN

  DELETE FROM RH_TrainingSubSubject WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

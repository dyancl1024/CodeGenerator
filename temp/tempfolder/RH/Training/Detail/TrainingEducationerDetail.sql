/*
  RH_TrainingEducationer - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingEducationer_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingEducationer_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     DesignID,
     UserID,
     CreateBy,
     CreateTime
  FROM RH_TrainingEducationer
  WHERE ID = i_ID ;

END;

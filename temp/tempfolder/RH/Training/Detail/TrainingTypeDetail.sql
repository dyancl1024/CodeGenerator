/*
  RH_TrainingType - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingType_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingType_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     Name,
     Code,
     Sort
  FROM RH_TrainingType
  WHERE ID = i_ID ;

END;

/*
  RH_TrainingHomeWorkType - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingHomeWorkType_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingHomeWorkType_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     Name,
     Code,
     Sort
  FROM RH_TrainingHomeWorkType
  WHERE ID = i_ID ;

END;

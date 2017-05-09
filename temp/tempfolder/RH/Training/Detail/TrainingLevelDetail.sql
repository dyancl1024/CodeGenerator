/*
  RH_TrainingLevel - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingLevel_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingLevel_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     Name,
     Code,
     Sort
  FROM RH_TrainingLevel
  WHERE ID = i_ID ;

END;

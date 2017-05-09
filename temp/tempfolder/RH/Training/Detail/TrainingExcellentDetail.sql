/*
  RH_TrainingExcellent - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingExcellent_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingExcellent_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     TID,
     UserID,
     Ttype,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime
  FROM RH_TrainingExcellent
  WHERE ID = i_ID ;

END;

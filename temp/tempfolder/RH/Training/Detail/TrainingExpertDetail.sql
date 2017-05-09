/*
  RH_TrainingExpert - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingExpert_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingExpert_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     TID,
     SubTID,
     UserID,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime
  FROM RH_TrainingExpert
  WHERE ID = i_ID ;

END;

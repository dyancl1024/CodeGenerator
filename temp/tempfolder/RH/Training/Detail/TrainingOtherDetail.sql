/*
  RH_TrainingOther - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingOther_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingOther_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     TID,
     SubTID,
     TTitle,
     TType,
     TContent,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime
  FROM RH_TrainingOther
  WHERE ID = i_ID ;

END;

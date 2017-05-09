/*
  RH_TrainingClassUserRelation - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingClassUserRelation_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingClassUserRelation_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     UserID,
     ClassID,
     SubTID,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime
  FROM RH_TrainingClassUserRelation
  WHERE ID = i_ID ;

END;

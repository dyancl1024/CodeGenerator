/*
  RH_TrainingMyHomeWork - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingMyHomeWork_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingMyHomeWork_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     HomeWorkTitle,
     HomeWorkContent,
     HomeWorkPhaseID,
     SubTID,
     Status,
     CreateBy,
     CreateTime
  FROM RH_TrainingMyHomeWork
  WHERE ID = i_ID ;

END;

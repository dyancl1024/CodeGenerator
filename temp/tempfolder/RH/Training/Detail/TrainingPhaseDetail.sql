/*
  RH_TrainingPhase - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingPhase_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingPhase_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     SubTID,
     PType,
     HomeName,
     HomeWorkDesc,
     HomeWorkCode,
     Phase,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime
  FROM RH_TrainingPhase
  WHERE ID = i_ID ;

END;

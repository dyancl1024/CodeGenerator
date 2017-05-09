/*
  RH_TrainingClassRule - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingClassRule_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingClassRule_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     SubTID,
     GradeCode,
     SubjectCode,
     ClassNum,
     UpdateBy,
     UpdateTime
  FROM RH_TrainingClassRule
  WHERE ID = i_ID ;

END;

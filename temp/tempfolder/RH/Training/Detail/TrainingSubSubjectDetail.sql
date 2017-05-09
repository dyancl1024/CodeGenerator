/*
  RH_TrainingSubSubject - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingSubSubject_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingSubSubject_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     SubTID,
     GradeCode,
     SubjectCode,
     CreateBy,
     CreateTime
  FROM RH_TrainingSubSubject
  WHERE ID = i_ID ;

END;

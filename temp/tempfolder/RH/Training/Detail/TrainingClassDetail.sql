/*
  RH_TrainingClass - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingClass_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingClass_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     SubTID,
     ClassNO,
     CName,
     SubjectCode,
     GradeCode,
     StaticUrl,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime
  FROM RH_TrainingClass
  WHERE ID = i_ID ;

END;

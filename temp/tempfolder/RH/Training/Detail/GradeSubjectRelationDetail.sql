/*
  RH_GradeSubjectRelation - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_GradeSubjectRelation_Detail;
CREATE  PROCEDURE sp_SJ_RH_GradeSubjectRelation_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     GradeCode,
     SubjectCode
  FROM RH_GradeSubjectRelation
  WHERE ID = i_ID ;

END;

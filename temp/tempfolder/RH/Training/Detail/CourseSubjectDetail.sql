/*
  RH_CourseSubject - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseSubject_Detail;
CREATE  PROCEDURE sp_SJ_RH_CourseSubject_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     CourseID,
     GradeCode,
     SubjectCode,
     CreateBy,
     CreateTime
  FROM RH_CourseSubject
  WHERE ID = i_ID ;

END;

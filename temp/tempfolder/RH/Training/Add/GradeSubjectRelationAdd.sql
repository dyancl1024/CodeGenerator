/*
  RH_GradeSubjectRelation - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_GradeSubjectRelation_Add;
CREATE  PROCEDURE sp_SJ_RH_GradeSubjectRelation_Add
(
   IN i_GradeCode varchar(50),
   IN i_SubjectCode varchar(50),
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_GradeSubjectRelation
  (
      GradeCode,
      SubjectCode
  )
  VALUES
  (
      i_GradeCode,  --  varchar(50) (学段代码)
      i_SubjectCode  --  varchar(50) (学科code)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

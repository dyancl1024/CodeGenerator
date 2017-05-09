/*
  RH_GradeSubjectRelation - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_GradeSubjectRelation_Modify;
CREATE  PROCEDURE sp_SJ_RH_GradeSubjectRelation_Modify
(
   IN i_ID int,
   IN i_GradeCode varchar(50),
   IN i_SubjectCode varchar(50),
   OUT o_Result int
)
BEGIN

  UPDATE RH_GradeSubjectRelation
  SET
      GradeCode = i_GradeCode,
      SubjectCode = i_SubjectCode
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

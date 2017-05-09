/*
  RH_CourseSubject - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseSubject_Add;
CREATE  PROCEDURE sp_SJ_RH_CourseSubject_Add
(
   IN i_CourseID int,
   IN i_GradeCode varchar(50),
   IN i_SubjectCode varchar(50),
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_CourseSubject
  (
      CourseID,
      GradeCode,
      SubjectCode,
      CreateBy,
      CreateTime
  )
  VALUES
  (
      i_CourseID,  --  int (CourseID)
      i_GradeCode,  --  varchar(50) (GradeCode)
      i_SubjectCode,  --  varchar(50) (SubjectCode)
      i_CreateBy,  --  int (CreateBy)
      i_CreateTime  --  datetime (CreateTime)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

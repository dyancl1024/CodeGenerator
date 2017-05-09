/*
  RH_UserSubjectRule - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_UserSubjectRule_Add;
CREATE  PROCEDURE sp_SJ_RH_UserSubjectRule_Add
(
   IN i_UserID int,
   IN i_GradeCode varchar(50),
   IN i_SubjectCode varchar(50),
   IN i_TID int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_UserSubjectRule
  (
      UserID,
      GradeCode,
      SubjectCode,
      TID
  )
  VALUES
  (
      i_UserID,  --  int (用户id)
      i_GradeCode,  --  varchar(50) (学段id)
      i_SubjectCode,  --  varchar(50) (学科ID)
      i_TID  --  int (子项目ID  一个学员在一个项目下只有一个学段学科)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

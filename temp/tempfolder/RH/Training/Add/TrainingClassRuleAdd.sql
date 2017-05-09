/*
  RH_TrainingClassRule - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingClassRule_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingClassRule_Add
(
   IN i_SubTID int,
   IN i_GradeCode varchar(50),
   IN i_SubjectCode varchar(50),
   IN i_ClassNum int,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingClassRule
  (
      SubTID,
      GradeCode,
      SubjectCode,
      ClassNum,
      UpdateBy,
      UpdateTime
  )
  VALUES
  (
      i_SubTID,  --  int (子项目ID)
      i_GradeCode,  --  varchar(50) (学段代码)
      i_SubjectCode,  --  varchar(50) (学科code)
      i_ClassNum,  --  int (ClassNum)
      i_UpdateBy,  --  int (更新人)
      i_UpdateTime  --  datetime (更新时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

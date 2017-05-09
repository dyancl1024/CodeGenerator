/*
  RH_TrainingSubSubject - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingSubSubject_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingSubSubject_Add
(
   IN i_SubTID int,
   IN i_GradeCode varchar(50),
   IN i_SubjectCode varchar(50),
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingSubSubject
  (
      SubTID,
      GradeCode,
      SubjectCode,
      CreateBy,
      CreateTime
  )
  VALUES
  (
      i_SubTID,  --  int (SubTID)
      i_GradeCode,  --  varchar(50) (GradeCode)
      i_SubjectCode,  --  varchar(50) (SubjectCode)
      i_CreateBy,  --  int (CreateBy)
      i_CreateTime  --  datetime (CreateTime)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

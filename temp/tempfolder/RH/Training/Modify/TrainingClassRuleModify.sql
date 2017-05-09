/*
  RH_TrainingClassRule - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingClassRule_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingClassRule_Modify
(
   IN i_ID int,
   IN i_SubTID int,
   IN i_GradeCode varchar(50),
   IN i_SubjectCode varchar(50),
   IN i_ClassNum int,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_TrainingClassRule
  SET
      SubTID = i_SubTID,
      GradeCode = i_GradeCode,
      SubjectCode = i_SubjectCode,
      ClassNum = i_ClassNum,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

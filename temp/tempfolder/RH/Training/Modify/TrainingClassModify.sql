/*
  RH_TrainingClass - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingClass_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingClass_Modify
(
   IN i_ID int,
   IN i_SubTID int,
   IN i_ClassNO int,
   IN i_CName nvarchar(50),
   IN i_SubjectCode varchar(50),
   IN i_GradeCode varchar(50),
   IN i_StaticUrl nvarchar(200),
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_TrainingClass
  SET
      SubTID = i_SubTID,
      ClassNO = i_ClassNO,
      CName = i_CName,
      SubjectCode = i_SubjectCode,
      GradeCode = i_GradeCode,
      StaticUrl = i_StaticUrl,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

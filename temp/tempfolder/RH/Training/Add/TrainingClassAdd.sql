/*
  RH_TrainingClass - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingClass_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingClass_Add
(
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

  INSERT INTO RH_TrainingClass
  (
      SubTID,
      ClassNO,
      CName,
      SubjectCode,
      GradeCode,
      StaticUrl,
      CreateBy,
      CreateTime,
      UpdateBy,
      UpdateTime
  )
  VALUES
  (
      i_SubTID,  --  int (项目id)
      i_ClassNO,  --  int (班号)
      i_CName,  --  nvarchar(50) (班级名称)
      i_SubjectCode,  --  varchar(50) (学科id)
      i_GradeCode,  --  varchar(50) (学段id)
      i_StaticUrl,  --  nvarchar(200) (StaticUrl)
      i_CreateBy,  --  int (创建人)
      i_CreateTime,  --  datetime (发布时间)
      i_UpdateBy,  --  int (更新人)
      i_UpdateTime  --  datetime (更新时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

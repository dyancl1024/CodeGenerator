/*
  RH_TrainingPhase - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingPhase_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingPhase_Add
(
   IN i_SubTID int,
   IN i_PType int,
   IN i_HomeName nvarchar(50),
   IN i_HomeWorkDesc nvarchar(200),
   IN i_HomeWorkCode varchar(50),
   IN i_Phase int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingPhase
  (
      SubTID,
      PType,
      HomeName,
      HomeWorkDesc,
      HomeWorkCode,
      Phase,
      CreateBy,
      CreateTime,
      UpdateBy,
      UpdateTime
  )
  VALUES
  (
      i_SubTID,  --  int (SubTID)
      i_PType,  --  int (1 课程学时 2.作业学时)
      i_HomeName,  --  nvarchar(50) (作业名称)
      i_HomeWorkDesc,  --  nvarchar(200) (作业描述)
      i_HomeWorkCode,  --  varchar(50) (作业类型：表RH_TrainingHomeWorkType)
      i_Phase,  --  int (Phase)
      i_CreateBy,  --  int (导入人)
      i_CreateTime,  --  datetime (导入时间)
      i_UpdateBy,  --  int (更新人)
      i_UpdateTime  --  datetime (更新时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

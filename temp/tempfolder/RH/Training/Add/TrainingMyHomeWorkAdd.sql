/*
  RH_TrainingMyHomeWork - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingMyHomeWork_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingMyHomeWork_Add
(
   IN i_HomeWorkTitle nvarchar(50),
   IN i_HomeWorkContent nvarchar(Max),
   IN i_HomeWorkPhaseID int,
   IN i_SubTID int,
   IN i_Status int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingMyHomeWork
  (
      HomeWorkTitle,
      HomeWorkContent,
      HomeWorkPhaseID,
      SubTID,
      Status,
      CreateBy,
      CreateTime
  )
  VALUES
  (
      i_HomeWorkTitle,  --  nvarchar(50) (作业标题)
      i_HomeWorkContent,  --  nvarchar(Max) (作业内容)
      i_HomeWorkPhaseID,  --  int (作业指标ID  RH_TrainingPhase)
      i_SubTID,  --  int (阶段项目ID)
      i_Status,  --  int (作业状态：1.待提交 2.待审批 3.不合格 4.合格 5.优秀 -不合格时（待提交）)
      i_CreateBy,  --  int (导入人)
      i_CreateTime  --  datetime (导入时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

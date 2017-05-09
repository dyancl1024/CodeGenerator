/*
  RH_TrainingOther - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingOther_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingOther_Add
(
   IN i_TID int,
   IN i_SubTID int,
   IN i_TTitle nvarchar(50),
   IN i_TType int,
   IN i_TContent nvarchar(Max),
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingOther
  (
      TID,
      SubTID,
      TTitle,
      TType,
      TContent,
      CreateBy,
      CreateTime,
      UpdateBy,
      UpdateTime
  )
  VALUES
  (
      i_TID,  --  int (TID)
      i_SubTID,  --  int (SubTID)
      i_TTitle,  --  nvarchar(50) (TTitle)
      i_TType,  --  int (项目附属信息  1.项目考核方案 2.学员手册 3.辅导老师手册 4.项目实施方案)
      i_TContent,  --  nvarchar(Max) (TContent)
      i_CreateBy,  --  int (创建人)
      i_CreateTime,  --  datetime (创建时间)
      i_UpdateBy,  --  int (更新人)
      i_UpdateTime  --  datetime (更新时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

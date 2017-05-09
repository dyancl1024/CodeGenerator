/*
  RH_TrainingBriefing - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingBriefing_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingBriefing_Add
(
   IN i_ObjectID int,
   IN i_MType int,
   IN i_Periods nvarchar(50),
   IN i_Title nvarchar(200),
   IN i_BContnet nvarchar(Max),
   IN i_ClickNum int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   IN i_StaticUrl nvarchar(200),
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingBriefing
  (
      ObjectID,
      MType,
      Periods,
      Title,
      BContnet,
      ClickNum,
      CreateBy,
      CreateTime,
      UpdateBy,
      UpdateTime,
      StaticUrl
  )
  VALUES
  (
      i_ObjectID,  --  int (项目id)
      i_MType,  --  int (1.项目 2.班级)
      i_Periods,  --  nvarchar(50) (期数 录入)
      i_Title,  --  nvarchar(200) (标题)
      i_BContnet,  --  nvarchar(Max) (内容)
      i_ClickNum,  --  int (ClickNum)
      i_CreateBy,  --  int (创建人)
      i_CreateTime,  --  datetime (发布时间)
      i_UpdateBy,  --  int (更新人)
      i_UpdateTime,  --  datetime (更新时间)
      i_StaticUrl  --  nvarchar(200) (StaticUrl)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

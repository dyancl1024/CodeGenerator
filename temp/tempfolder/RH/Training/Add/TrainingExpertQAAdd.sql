/*
  RH_TrainingExpertQA - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingExpertQA_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingExpertQA_Add
(
   IN i_TID int,
   IN i_QATitle nvarchar(50),
   IN i_QAContent nvarchar(Max),
   IN i_ClickNum int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingExpertQA
  (
      TID,
      QATitle,
      QAContent,
      ClickNum,
      CreateBy,
      CreateTime,
      UpdateBy,
      UpdateTime
  )
  VALUES
  (
      i_TID,  --  int (项目id)
      i_QATitle,  --  nvarchar(50) (答疑标题)
      i_QAContent,  --  nvarchar(Max) (答疑内容)
      i_ClickNum,  --  int (点击率)
      i_CreateBy,  --  int (创建人)
      i_CreateTime,  --  datetime (创建时间)
      i_UpdateBy,  --  int (更新人)
      i_UpdateTime  --  datetime (更新时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

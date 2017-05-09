/*
  RH_TrainingExpertQA - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingExpertQA_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingExpertQA_Modify
(
   IN i_ID int,
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

  UPDATE RH_TrainingExpertQA
  SET
      TID = i_TID,
      QATitle = i_QATitle,
      QAContent = i_QAContent,
      ClickNum = i_ClickNum,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

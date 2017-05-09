/*
  RH_TrainingExpertQA - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingExpertQA_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingExpertQA_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     TID,
     QATitle,
     QAContent,
     ClickNum,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime
  FROM RH_TrainingExpertQA
  WHERE ID = i_ID ;

END;

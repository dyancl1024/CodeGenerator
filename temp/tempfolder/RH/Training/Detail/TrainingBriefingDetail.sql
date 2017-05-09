/*
  RH_TrainingBriefing - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingBriefing_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingBriefing_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
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
  FROM RH_TrainingBriefing
  WHERE ID = i_ID ;

END;

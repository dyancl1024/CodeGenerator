/*
  RH_TrainingBriefing - 查看列表脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingBriefing_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingBriefing_Detail
(
   IN i_PageSize int,
   IN i_PageIndex int,
   OUT o_TotlaCount int
)
BEGIN

  SELECT COUNT(1) INTO o_TotlaCount FROM RH_TrainingBriefing;

  SELECT 
     ID,
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
   WHERE 1=1 
   LIMIT i_PageIndex,i_PageSize ;

END;

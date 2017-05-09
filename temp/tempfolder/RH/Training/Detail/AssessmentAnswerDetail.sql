/*
  RH_AssessmentAnswer - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_AssessmentAnswer_Detail;
CREATE  PROCEDURE sp_SJ_RH_AssessmentAnswer_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     SubTID,
     UserID,
     QID,
     QType,
     OptionID,
     Score
  FROM RH_AssessmentAnswer
  WHERE ID = i_ID ;

END;

/*
  RH_AssessmentAnswerBak - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_AssessmentAnswerBak_Detail;
CREATE  PROCEDURE sp_SJ_RH_AssessmentAnswerBak_Detail
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
  FROM RH_AssessmentAnswerBak
  WHERE ID = i_ID ;

END;

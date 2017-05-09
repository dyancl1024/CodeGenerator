/*
  RH_AssessmentAnswerBak - 查看列表脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_AssessmentAnswerBak_Detail;
CREATE  PROCEDURE sp_SJ_RH_AssessmentAnswerBak_Detail
(
   IN i_PageSize int,
   IN i_PageIndex int,
   OUT o_TotlaCount int
)
BEGIN

  SELECT COUNT(1) INTO o_TotlaCount FROM RH_AssessmentAnswerBak;

  SELECT 
     ID,
     SubTID,
     UserID,
     QID,
     QType,
     OptionID,
     Score
   FROM RH_AssessmentAnswerBak
   WHERE 1=1 
   LIMIT i_PageIndex,i_PageSize ;

END;

/*
  RH_AssessmentAnswerBak - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_AssessmentAnswerBak_Modify;
CREATE  PROCEDURE sp_SJ_RH_AssessmentAnswerBak_Modify
(
   IN i_ID int,
   IN i_SubTID int,
   IN i_UserID int,
   IN i_QID int,
   IN i_QType int,
   IN i_OptionID int,
   IN i_Score int,
   OUT o_Result int
)
BEGIN

  UPDATE RH_AssessmentAnswerBak
  SET
      SubTID = i_SubTID,
      UserID = i_UserID,
      QID = i_QID,
      QType = i_QType,
      OptionID = i_OptionID,
      Score = i_Score
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

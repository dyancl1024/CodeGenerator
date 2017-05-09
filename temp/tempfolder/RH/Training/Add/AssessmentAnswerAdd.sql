/*
  RH_AssessmentAnswer - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_AssessmentAnswer_Add;
CREATE  PROCEDURE sp_SJ_RH_AssessmentAnswer_Add
(
   IN i_SubTID int,
   IN i_UserID int,
   IN i_QID int,
   IN i_QType int,
   IN i_OptionID int,
   IN i_Score int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_AssessmentAnswer
  (
      SubTID,
      UserID,
      QID,
      QType,
      OptionID,
      Score
  )
  VALUES
  (
      i_SubTID,  --  int (项目id)
      i_UserID,  --  int (用户id)
      i_QID,  --  int (问题id)
      i_QType,  --  int (问题类型  RH_AssessmentQuestionType表id)
      i_OptionID,  --  int (选项id  RH_AssessmentOptions表id)
      i_Score  --  int (得分)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

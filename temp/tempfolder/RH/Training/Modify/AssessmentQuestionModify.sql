/*
  RH_AssessmentQuestion - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_AssessmentQuestion_Modify;
CREATE  PROCEDURE sp_SJ_RH_AssessmentQuestion_Modify
(
   IN i_ID int,
   IN i_AssessmentID int,
   IN i_Question nvarchar(Max),
   IN i_QuestionDesc nvarchar(Max),
   IN i_TypeID int,
   IN i_Dimensions int,
   IN i_SortNo int,
   IN i_Status int,
   OUT o_Result int
)
BEGIN

  UPDATE RH_AssessmentQuestion
  SET
      AssessmentID = i_AssessmentID,
      Question = i_Question,
      QuestionDesc = i_QuestionDesc,
      TypeID = i_TypeID,
      Dimensions = i_Dimensions,
      SortNo = i_SortNo,
      Status = i_Status
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

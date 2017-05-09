/*
  RH_AssessmentQuestion - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_AssessmentQuestion_Add;
CREATE  PROCEDURE sp_SJ_RH_AssessmentQuestion_Add
(
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

  INSERT INTO RH_AssessmentQuestion
  (
      AssessmentID,
      Question,
      QuestionDesc,
      TypeID,
      Dimensions,
      SortNo,
      Status
  )
  VALUES
  (
      i_AssessmentID,  --  int (测评工具id 对应RH_Assessment表id)
      i_Question,  --  nvarchar(Max) (题干)
      i_QuestionDesc,  --  nvarchar(Max) (题干描述)
      i_TypeID,  --  int (题型 对应RH_AssessmentQuestionType表id)
      i_Dimensions,  --  int (课堂维度：1.课堂教学 2.学习方式)
      i_SortNo,  --  int (排序)
      i_Status  --  int (状态 0.未发布 1.发布)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

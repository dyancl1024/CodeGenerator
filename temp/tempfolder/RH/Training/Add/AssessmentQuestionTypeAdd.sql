/*
  RH_AssessmentQuestionType - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_AssessmentQuestionType_Add;
CREATE  PROCEDURE sp_SJ_RH_AssessmentQuestionType_Add
(
   IN i_TypeName nvarchar(50),
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_AssessmentQuestionType
  (
      TypeName
  )
  VALUES
  (
      i_TypeName  --  nvarchar(50) (问题类型)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

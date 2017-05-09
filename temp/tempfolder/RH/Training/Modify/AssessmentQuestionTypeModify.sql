/*
  RH_AssessmentQuestionType - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_AssessmentQuestionType_Modify;
CREATE  PROCEDURE sp_SJ_RH_AssessmentQuestionType_Modify
(
   IN i_ID int,
   IN i_TypeName nvarchar(50),
   OUT o_Result int
)
BEGIN

  UPDATE RH_AssessmentQuestionType
  SET
      TypeName = i_TypeName
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

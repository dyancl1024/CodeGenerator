/*
  RH_AssessmentQuestionType - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_AssessmentQuestionType_Detail;
CREATE  PROCEDURE sp_SJ_RH_AssessmentQuestionType_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     TypeName
  FROM RH_AssessmentQuestionType
  WHERE ID = i_ID ;

END;

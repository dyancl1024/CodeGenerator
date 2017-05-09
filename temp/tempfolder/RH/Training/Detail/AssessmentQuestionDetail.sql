/*
  RH_AssessmentQuestion - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_AssessmentQuestion_Detail;
CREATE  PROCEDURE sp_SJ_RH_AssessmentQuestion_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     AssessmentID,
     Question,
     QuestionDesc,
     TypeID,
     Dimensions,
     SortNo,
     Status
  FROM RH_AssessmentQuestion
  WHERE ID = i_ID ;

END;

/*
  RH_AssessmentOptions - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_AssessmentOptions_Detail;
CREATE  PROCEDURE sp_SJ_RH_AssessmentOptions_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     QID,
     Options,
     SortNO,
     Score
  FROM RH_AssessmentOptions
  WHERE ID = i_ID ;

END;

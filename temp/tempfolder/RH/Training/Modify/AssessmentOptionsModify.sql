/*
  RH_AssessmentOptions - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_AssessmentOptions_Modify;
CREATE  PROCEDURE sp_SJ_RH_AssessmentOptions_Modify
(
   IN i_ID int,
   IN i_QID int,
   IN i_Options nvarchar(Max),
   IN i_SortNO int,
   IN i_Score int,
   OUT o_Result int
)
BEGIN

  UPDATE RH_AssessmentOptions
  SET
      QID = i_QID,
      Options = i_Options,
      SortNO = i_SortNO,
      Score = i_Score
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

/*
  RH_AssessmentOptions - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_AssessmentOptions_Add;
CREATE  PROCEDURE sp_SJ_RH_AssessmentOptions_Add
(
   IN i_QID int,
   IN i_Options nvarchar(Max),
   IN i_SortNO int,
   IN i_Score int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_AssessmentOptions
  (
      QID,
      Options,
      SortNO,
      Score
  )
  VALUES
  (
      i_QID,  --  int (问题id)
      i_Options,  --  nvarchar(Max) (选项)
      i_SortNO,  --  int (排序)
      i_Score  --  int (分值  1.1分 2.2分 3.3分)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

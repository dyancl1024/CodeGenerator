/*
  RH_CourseOption - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseOption_Modify;
CREATE  PROCEDURE sp_SJ_RH_CourseOption_Modify
(
   IN i_ID int,
   IN i_QuestionID int,
   IN i_QOption nvarchar(200),
   IN i_Sort int,
   IN i_IsRight int,
   OUT o_Result int
)
BEGIN

  UPDATE RH_CourseOption
  SET
      QuestionID = i_QuestionID,
      QOption = i_QOption,
      Sort = i_Sort,
      IsRight = i_IsRight
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

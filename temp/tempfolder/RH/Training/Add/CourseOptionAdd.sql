/*
  RH_CourseOption - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseOption_Add;
CREATE  PROCEDURE sp_SJ_RH_CourseOption_Add
(
   IN i_QuestionID int,
   IN i_QOption nvarchar(200),
   IN i_Sort int,
   IN i_IsRight int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_CourseOption
  (
      QuestionID,
      QOption,
      Sort,
      IsRight
  )
  VALUES
  (
      i_QuestionID,  --  int (QuestionID)
      i_QOption,  --  nvarchar(200) (QOption)
      i_Sort,  --  int (Sort)
      i_IsRight  --  int (是否标准答案1是2否)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

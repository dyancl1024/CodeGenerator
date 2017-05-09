/*
  RH_CourseAnswer - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseAnswer_Add;
CREATE  PROCEDURE sp_SJ_RH_CourseAnswer_Add
(
   IN i_QuestionID int,
   IN i_OptionID int,
   IN i_IsRight int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_CourseAnswer
  (
      QuestionID,
      OptionID,
      IsRight,
      CreateBy,
      CreateTime
  )
  VALUES
  (
      i_QuestionID,  --  int (QuestionID)
      i_OptionID,  --  int (OptionID)
      i_IsRight,  --  int (IsRight)
      i_CreateBy,  --  int (CreateBy)
      i_CreateTime  --  datetime (创建时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

/*
  RH_CourseAnswer - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseAnswer_Modify;
CREATE  PROCEDURE sp_SJ_RH_CourseAnswer_Modify
(
   IN i_ID int,
   IN i_QuestionID int,
   IN i_OptionID int,
   IN i_IsRight int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_CourseAnswer
  SET
      QuestionID = i_QuestionID,
      OptionID = i_OptionID,
      IsRight = i_IsRight,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

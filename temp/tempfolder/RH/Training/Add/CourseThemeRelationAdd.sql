/*
  RH_CourseThemeRelation - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseThemeRelation_Add;
CREATE  PROCEDURE sp_SJ_RH_CourseThemeRelation_Add
(
   IN i_CourseID int,
   IN i_CourseThemeCode varchar(50),
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_CourseThemeRelation
  (
      CourseID,
      CourseThemeCode
  )
  VALUES
  (
      i_CourseID,  --  int (课程id)
      i_CourseThemeCode  --  varchar(50) (能力提升课程代码)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

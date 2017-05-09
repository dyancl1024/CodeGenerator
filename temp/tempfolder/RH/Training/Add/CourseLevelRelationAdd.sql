/*
  RH_CourseLevelRelation - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseLevelRelation_Add;
CREATE  PROCEDURE sp_SJ_RH_CourseLevelRelation_Add
(
   IN i_CourseID int,
   IN i_CourseLevel int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_CourseLevelRelation
  (
      CourseID,
      CourseLevel
  )
  VALUES
  (
      i_CourseID,  --  int (CourseID)
      i_CourseLevel  --  int (1初级2中级3高级)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

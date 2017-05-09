/*
  RH_CourseLevelRelation - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseLevelRelation_Modify;
CREATE  PROCEDURE sp_SJ_RH_CourseLevelRelation_Modify
(
   IN i_ID int,
   IN i_CourseID int,
   IN i_CourseLevel int,
   OUT o_Result int
)
BEGIN

  UPDATE RH_CourseLevelRelation
  SET
      CourseID = i_CourseID,
      CourseLevel = i_CourseLevel
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

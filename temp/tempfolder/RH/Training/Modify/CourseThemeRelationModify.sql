/*
  RH_CourseThemeRelation - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseThemeRelation_Modify;
CREATE  PROCEDURE sp_SJ_RH_CourseThemeRelation_Modify
(
   IN i_ID int,
   IN i_CourseID int,
   IN i_CourseThemeCode varchar(50),
   OUT o_Result int
)
BEGIN

  UPDATE RH_CourseThemeRelation
  SET
      CourseID = i_CourseID,
      CourseThemeCode = i_CourseThemeCode
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

/*
  RH_CourseThemeRelation - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseThemeRelation_Detail;
CREATE  PROCEDURE sp_SJ_RH_CourseThemeRelation_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     CourseID,
     CourseThemeCode
  FROM RH_CourseThemeRelation
  WHERE ID = i_ID ;

END;

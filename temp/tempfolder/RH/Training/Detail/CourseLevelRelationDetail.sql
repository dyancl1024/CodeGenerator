/*
  RH_CourseLevelRelation - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseLevelRelation_Detail;
CREATE  PROCEDURE sp_SJ_RH_CourseLevelRelation_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     CourseID,
     CourseLevel
  FROM RH_CourseLevelRelation
  WHERE ID = i_ID ;

END;

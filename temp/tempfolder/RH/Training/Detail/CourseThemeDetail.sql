/*
  RH_CourseTheme - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseTheme_Detail;
CREATE  PROCEDURE sp_SJ_RH_CourseTheme_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     Name,
     Code,
     Sort,
     Type
  FROM RH_CourseTheme
  WHERE ID = i_ID ;

END;

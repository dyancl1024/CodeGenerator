/*
  RH_CourseCategory - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseCategory_Detail;
CREATE  PROCEDURE sp_SJ_RH_CourseCategory_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     Name,
     Code,
     Type,
     Sort
  FROM RH_CourseCategory
  WHERE ID = i_ID ;

END;

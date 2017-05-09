/*
  RH_CoursePreSetList - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CoursePreSetList_Detail;
CREATE  PROCEDURE sp_SJ_RH_CoursePreSetList_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     PreSetID,
     CourseID
  FROM RH_CoursePreSetList
  WHERE ID = i_ID ;

END;

/*
  RH_CoursePreset - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CoursePreset_Detail;
CREATE  PROCEDURE sp_SJ_RH_CoursePreset_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     Name,
     CPDesc,
     IfPromote,
     IsRequired,
     CourseLevel,
     Dimension,
     Version,
     parentID,
     Status,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime
  FROM RH_CoursePreset
  WHERE ID = i_ID ;

END;

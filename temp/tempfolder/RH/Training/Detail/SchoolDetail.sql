/*
  RH_School - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_School_Detail;
CREATE  PROCEDURE sp_SJ_RH_School_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     DistrictID,
     SchoolName,
     Status,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime
  FROM RH_School
  WHERE ID = i_ID ;

END;

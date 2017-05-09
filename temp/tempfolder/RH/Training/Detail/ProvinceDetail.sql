/*
  RH_Province - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Province_Detail;
CREATE  PROCEDURE sp_SJ_RH_Province_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     ProvinceName,
     ProvincePY,
     CountyID,
     Status
  FROM RH_Province
  WHERE ID = i_ID ;

END;

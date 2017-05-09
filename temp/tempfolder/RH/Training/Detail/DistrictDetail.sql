/*
  RH_District - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_District_Detail;
CREATE  PROCEDURE sp_SJ_RH_District_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     DistrictName,
     DistrictPY,
     CityID
  FROM RH_District
  WHERE ID = i_ID ;

END;

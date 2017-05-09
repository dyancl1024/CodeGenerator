/*
  RH_City - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_City_Detail;
CREATE  PROCEDURE sp_SJ_RH_City_Detail
(
   IN i_id int
)
BEGIN

  SELECT 
     CityName,
     CityPY,
     ProvinceID
  FROM RH_City
  WHERE id = i_id ;

END;

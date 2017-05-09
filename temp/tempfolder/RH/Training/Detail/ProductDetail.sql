/*
  RH_Product - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Product_Detail;
CREATE  PROCEDURE sp_SJ_RH_Product_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     ProductName,
     ProductCode,
     ProductLevel,
     ProductUrl,
     Status,
     ProvinceID,
     CityID,
     DistrictID,
     StaticUrl,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime
  FROM RH_Product
  WHERE ID = i_ID ;

END;

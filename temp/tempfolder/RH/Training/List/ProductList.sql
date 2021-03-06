/*
  RH_Product - 查看列表脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Product_Detail;
CREATE  PROCEDURE sp_SJ_RH_Product_Detail
(
   IN i_PageSize int,
   IN i_PageIndex int,
   OUT o_TotlaCount int
)
BEGIN

  SELECT COUNT(1) INTO o_TotlaCount FROM RH_Product;

  SELECT 
     ID,
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
   WHERE 1=1 
   LIMIT i_PageIndex,i_PageSize ;

END;

/*
  RH_Product - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Product_Modify;
CREATE  PROCEDURE sp_SJ_RH_Product_Modify
(
   IN i_ID int,
   IN i_ProductName nvarchar(50),
   IN i_ProductCode varchar(50),
   IN i_ProductLevel int,
   IN i_ProductUrl nvarchar(50),
   IN i_Status int,
   IN i_ProvinceID int,
   IN i_CityID int,
   IN i_DistrictID int,
   IN i_StaticUrl nvarchar(200),
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_Product
  SET
      ProductName = i_ProductName,
      ProductCode = i_ProductCode,
      ProductLevel = i_ProductLevel,
      ProductUrl = i_ProductUrl,
      Status = i_Status,
      ProvinceID = i_ProvinceID,
      CityID = i_CityID,
      DistrictID = i_DistrictID,
      StaticUrl = i_StaticUrl,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

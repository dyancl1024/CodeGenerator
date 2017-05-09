/*
  RH_Product - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Product_Add;
CREATE  PROCEDURE sp_SJ_RH_Product_Add
(
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

  INSERT INTO RH_Product
  (
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
  )
  VALUES
  (
      i_ProductName,  --  nvarchar(50) (ProductName)
      i_ProductCode,  --  varchar(50) (ProductCode)
      i_ProductLevel,  --  int (产品级别 1.省 2. 市 3.区县)
      i_ProductUrl,  --  nvarchar(50) (ProductUrl)
      i_Status,  --  int (1.正常 2.删除)
      i_ProvinceID,  --  int (ProvinceID)
      i_CityID,  --  int (CityID)
      i_DistrictID,  --  int (DistrictID)
      i_StaticUrl,  --  nvarchar(200) (StaticUrl)
      i_CreateBy,  --  int (CreateBy)
      i_CreateTime,  --  datetime (CreateTime)
      i_UpdateBy,  --  int (UpdateBy)
      i_UpdateTime  --  datetime (UpdateTime)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

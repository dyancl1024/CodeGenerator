/*
  RH_City - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_City_Add;
CREATE  PROCEDURE sp_SJ_RH_City_Add
(
   IN i_CityName nvarchar(50),
   IN i_CityPY varchar(50),
   IN i_ProvinceID int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_City
  (
      CityName,
      CityPY,
      ProvinceID
  )
  VALUES
  (
      i_CityName,  --  nvarchar(50) (CityName)
      i_CityPY,  --  varchar(50) (CityPY)
      i_ProvinceID  --  int (ProvinceID)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

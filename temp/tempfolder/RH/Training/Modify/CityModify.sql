/*
  RH_City - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_City_Modify;
CREATE  PROCEDURE sp_SJ_RH_City_Modify
(
   IN i_id int,
   IN i_CityName nvarchar(50),
   IN i_CityPY varchar(50),
   IN i_ProvinceID int,
   OUT o_Result int
)
BEGIN

  UPDATE RH_City
  SET
      CityName = i_CityName,
      CityPY = i_CityPY,
      ProvinceID = i_ProvinceID
  WHERE id = i_id ;

  SELECT ROW_COUNT() INTO o_Result;

END;

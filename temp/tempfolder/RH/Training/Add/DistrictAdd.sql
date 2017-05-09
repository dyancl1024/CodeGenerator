/*
  RH_District - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_District_Add;
CREATE  PROCEDURE sp_SJ_RH_District_Add
(
   IN i_DistrictName nvarchar(50),
   IN i_DistrictPY varchar(50),
   IN i_CityID int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_District
  (
      DistrictName,
      DistrictPY,
      CityID
  )
  VALUES
  (
      i_DistrictName,  --  nvarchar(50) (DistrictName)
      i_DistrictPY,  --  varchar(50) (DistrictPY)
      i_CityID  --  int (CityID)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

/*
  RH_District - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_District_Modify;
CREATE  PROCEDURE sp_SJ_RH_District_Modify
(
   IN i_ID int,
   IN i_DistrictName nvarchar(50),
   IN i_DistrictPY varchar(50),
   IN i_CityID int,
   OUT o_Result int
)
BEGIN

  UPDATE RH_District
  SET
      DistrictName = i_DistrictName,
      DistrictPY = i_DistrictPY,
      CityID = i_CityID
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

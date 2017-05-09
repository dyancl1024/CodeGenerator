/*
  RH_Country - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Country_Modify;
CREATE  PROCEDURE sp_SJ_RH_Country_Modify
(
   IN i_ID int,
   IN i_CountryName nvarchar(50),
   IN i_CountryPY nvarchar(50),
   OUT o_Result int
)
BEGIN

  UPDATE RH_Country
  SET
      CountryName = i_CountryName,
      CountryPY = i_CountryPY
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

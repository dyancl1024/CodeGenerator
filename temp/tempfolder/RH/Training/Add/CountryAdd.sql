/*
  RH_Country - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Country_Add;
CREATE  PROCEDURE sp_SJ_RH_Country_Add
(
   IN i_CountryName nvarchar(50),
   IN i_CountryPY nvarchar(50),
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_Country
  (
      CountryName,
      CountryPY
  )
  VALUES
  (
      i_CountryName,  --  nvarchar(50) (国家名)
      i_CountryPY  --  nvarchar(50) (国家拼音)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

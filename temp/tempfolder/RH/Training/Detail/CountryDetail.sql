/*
  RH_Country - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Country_Detail;
CREATE  PROCEDURE sp_SJ_RH_Country_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     CountryName,
     CountryPY
  FROM RH_Country
  WHERE ID = i_ID ;

END;

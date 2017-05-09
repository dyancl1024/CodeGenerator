/*
  RH_BannerArea - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_BannerArea_Detail;
CREATE  PROCEDURE sp_SJ_RH_BannerArea_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     AreaCode,
     AreaName,
     AreaWidth,
     AreaHight,
     AreaType,
     AreaPicUrl
  FROM RH_BannerArea
  WHERE ID = i_ID ;

END;

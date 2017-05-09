/*
  RH_BannerArea - 查看列表脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_BannerArea_Detail;
CREATE  PROCEDURE sp_SJ_RH_BannerArea_Detail
(
   IN i_PageSize int,
   IN i_PageIndex int,
   OUT o_TotlaCount int
)
BEGIN

  SELECT COUNT(1) INTO o_TotlaCount FROM RH_BannerArea;

  SELECT 
     ID,
     AreaCode,
     AreaName,
     AreaWidth,
     AreaHight,
     AreaType,
     AreaPicUrl
   FROM RH_BannerArea
   WHERE 1=1 
   LIMIT i_PageIndex,i_PageSize ;

END;

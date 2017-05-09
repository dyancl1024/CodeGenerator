/*
  RH_BannerArea - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_BannerArea_Modify;
CREATE  PROCEDURE sp_SJ_RH_BannerArea_Modify
(
   IN i_ID int,
   IN i_AreaCode varchar(50),
   IN i_AreaName nvarchar(50),
   IN i_AreaWidth int,
   IN i_AreaHight int,
   IN i_AreaType int,
   IN i_AreaPicUrl nvarchar(50),
   OUT o_Result int
)
BEGIN

  UPDATE RH_BannerArea
  SET
      AreaCode = i_AreaCode,
      AreaName = i_AreaName,
      AreaWidth = i_AreaWidth,
      AreaHight = i_AreaHight,
      AreaType = i_AreaType,
      AreaPicUrl = i_AreaPicUrl
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

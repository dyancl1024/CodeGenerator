/*
  RH_BannerArea - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_BannerArea_Add;
CREATE  PROCEDURE sp_SJ_RH_BannerArea_Add
(
   IN i_AreaCode varchar(50),
   IN i_AreaName nvarchar(50),
   IN i_AreaWidth int,
   IN i_AreaHight int,
   IN i_AreaType int,
   IN i_AreaPicUrl nvarchar(50),
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_BannerArea
  (
      AreaCode,
      AreaName,
      AreaWidth,
      AreaHight,
      AreaType,
      AreaPicUrl
  )
  VALUES
  (
      i_AreaCode,  --  varchar(50) (广告区域编码)
      i_AreaName,  --  nvarchar(50) (AreaName)
      i_AreaWidth,  --  int (AreaWidth)
      i_AreaHight,  --  int (AreaHight)
      i_AreaType,  --  int (区域位置:  1-主项目页面 2-阶段项目页面 3-学习页面)
      i_AreaPicUrl  --  nvarchar(50) (广告位置指示效果图)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

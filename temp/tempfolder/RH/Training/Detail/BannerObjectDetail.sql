/*
  RH_BannerObject - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_BannerObject_Detail;
CREATE  PROCEDURE sp_SJ_RH_BannerObject_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     BannerID,
     ObjectID,
     CreateBy,
     CreateTime
  FROM RH_BannerObject
  WHERE ID = i_ID ;

END;

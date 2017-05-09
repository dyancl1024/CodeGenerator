/*
  RH_Banner - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Banner_Detail;
CREATE  PROCEDURE sp_SJ_RH_Banner_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     ADTitle,
     AreaCode,
     ADPhotoUrl,
     ADContentType,
     ADContentURL,
     ADContent,
     Status,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime
  FROM RH_Banner
  WHERE ID = i_ID ;

END;

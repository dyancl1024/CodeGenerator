/*
  RH_DesignBusiness - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_DesignBusiness_Detail;
CREATE  PROCEDURE sp_SJ_RH_DesignBusiness_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     DesignID,
     UserID,
     CreateBy,
     CreateTime
  FROM RH_DesignBusiness
  WHERE ID = i_ID ;

END;

/*
  RH_DesignSuggest - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_DesignSuggest_Detail;
CREATE  PROCEDURE sp_SJ_RH_DesignSuggest_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     DesignID,
     DSuggest,
     Status,
     CreateBy,
     CreateTime
  FROM RH_DesignSuggest
  WHERE ID = i_ID ;

END;

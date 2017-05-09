/*
  RH_DesignContent - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_DesignContent_Detail;
CREATE  PROCEDURE sp_SJ_RH_DesignContent_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     DesignID,
     DType,
     DName,
     DContent,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime
  FROM RH_DesignContent
  WHERE ID = i_ID ;

END;

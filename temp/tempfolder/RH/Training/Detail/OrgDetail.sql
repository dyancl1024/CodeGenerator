/*
  RH_Org - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Org_Detail;
CREATE  PROCEDURE sp_SJ_RH_Org_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     Name,
     Code,
     Sort,
     Status
  FROM RH_Org
  WHERE ID = i_ID ;

END;

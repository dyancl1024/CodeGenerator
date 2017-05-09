/*
  RH_MngRole - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_MngRole_Detail;
CREATE  PROCEDURE sp_SJ_RH_MngRole_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     RoleName,
     RoleCode,
     SortNum
  FROM RH_MngRole
  WHERE ID = i_ID ;

END;

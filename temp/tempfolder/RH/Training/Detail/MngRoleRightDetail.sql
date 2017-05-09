/*
  RH_MngRoleRight - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_MngRoleRight_Detail;
CREATE  PROCEDURE sp_SJ_RH_MngRoleRight_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     RoleCode,
     MenuCode,
     CreateBy,
     CreateTime
  FROM RH_MngRoleRight
  WHERE ID = i_ID ;

END;

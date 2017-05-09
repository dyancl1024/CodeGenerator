/*
  RH_MngRoleRight - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_MngRoleRight_Modify;
CREATE  PROCEDURE sp_SJ_RH_MngRoleRight_Modify
(
   IN i_ID int,
   IN i_RoleCode varchar(50),
   IN i_MenuCode varchar(50),
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_MngRoleRight
  SET
      RoleCode = i_RoleCode,
      MenuCode = i_MenuCode,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

/*
  RH_MngRole - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_MngRole_Modify;
CREATE  PROCEDURE sp_SJ_RH_MngRole_Modify
(
   IN i_ID int,
   IN i_RoleName nvarchar(50),
   IN i_RoleCode nvarchar(50),
   IN i_SortNum int,
   OUT o_Result int
)
BEGIN

  UPDATE RH_MngRole
  SET
      RoleName = i_RoleName,
      RoleCode = i_RoleCode,
      SortNum = i_SortNum
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

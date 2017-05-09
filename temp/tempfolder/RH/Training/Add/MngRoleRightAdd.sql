/*
  RH_MngRoleRight - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_MngRoleRight_Add;
CREATE  PROCEDURE sp_SJ_RH_MngRoleRight_Add
(
   IN i_RoleCode varchar(50),
   IN i_MenuCode varchar(50),
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_MngRoleRight
  (
      RoleCode,
      MenuCode,
      CreateBy,
      CreateTime
  )
  VALUES
  (
      i_RoleCode,  --  varchar(50) (RoleCode)
      i_MenuCode,  --  varchar(50) (菜单code  对应RH_MngMenu)
      i_CreateBy,  --  int (创建人)
      i_CreateTime  --  datetime (创建时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

/*
  RH_MngRole - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_MngRole_Add;
CREATE  PROCEDURE sp_SJ_RH_MngRole_Add
(
   IN i_RoleName nvarchar(50),
   IN i_RoleCode nvarchar(50),
   IN i_SortNum int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_MngRole
  (
      RoleName,
      RoleCode,
      SortNum
  )
  VALUES
  (
      i_RoleName,  --  nvarchar(50) (角色名称)
      i_RoleCode,  --  nvarchar(50) (角色代码)
      i_SortNum  --  int (角色排序)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

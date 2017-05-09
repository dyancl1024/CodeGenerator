/*
  RH_MngMenu - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_MngMenu_Add;
CREATE  PROCEDURE sp_SJ_RH_MngMenu_Add
(
   IN i_MenuName nvarchar(50),
   IN i_MenuUrl nvarchar(200),
   IN i_MenuCode varchar(50),
   IN i_MenuLevel int,
   IN i_MenuSort int,
   IN i_Status int,
   IN i_ParentID int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_MngMenu
  (
      MenuName,
      MenuUrl,
      MenuCode,
      MenuLevel,
      MenuSort,
      Status,
      ParentID
  )
  VALUES
  (
      i_MenuName,  --  nvarchar(50) (菜单名字)
      i_MenuUrl,  --  nvarchar(200) (菜单路径)
      i_MenuCode,  --  varchar(50) (MenuCode)
      i_MenuLevel,  --  int (菜单级别)
      i_MenuSort,  --  int (菜单排序)
      i_Status,  --  int (状态：1.正常2.删除)
      i_ParentID  --  int (父级菜单id)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

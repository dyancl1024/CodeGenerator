/*
  RH_MngMenu - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_MngMenu_Modify;
CREATE  PROCEDURE sp_SJ_RH_MngMenu_Modify
(
   IN i_ID int,
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

  UPDATE RH_MngMenu
  SET
      MenuName = i_MenuName,
      MenuUrl = i_MenuUrl,
      MenuCode = i_MenuCode,
      MenuLevel = i_MenuLevel,
      MenuSort = i_MenuSort,
      Status = i_Status,
      ParentID = i_ParentID
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

/*
  RH_MngMenu - 查看列表脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_MngMenu_Detail;
CREATE  PROCEDURE sp_SJ_RH_MngMenu_Detail
(
   IN i_PageSize int,
   IN i_PageIndex int,
   OUT o_TotlaCount int
)
BEGIN

  SELECT COUNT(1) INTO o_TotlaCount FROM RH_MngMenu;

  SELECT 
     ID,
     MenuName,
     MenuUrl,
     MenuCode,
     MenuLevel,
     MenuSort,
     Status,
     ParentID
   FROM RH_MngMenu
   WHERE 1=1 
   LIMIT i_PageIndex,i_PageSize ;

END;

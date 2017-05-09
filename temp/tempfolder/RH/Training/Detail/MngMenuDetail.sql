/*
  RH_MngMenu - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_MngMenu_Detail;
CREATE  PROCEDURE sp_SJ_RH_MngMenu_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     MenuName,
     MenuUrl,
     MenuCode,
     MenuLevel,
     MenuSort,
     Status,
     ParentID
  FROM RH_MngMenu
  WHERE ID = i_ID ;

END;

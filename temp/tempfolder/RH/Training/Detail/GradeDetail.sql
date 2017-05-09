/*
  RH_Grade - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Grade_Detail;
CREATE  PROCEDURE sp_SJ_RH_Grade_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     Name,
     Code,
     Sort,
     ParentID
  FROM RH_Grade
  WHERE ID = i_ID ;

END;

/*
  RH_Expert - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Expert_Detail;
CREATE  PROCEDURE sp_SJ_RH_Expert_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     UserID,
     CreateBy,
     CreateTime
  FROM RH_Expert
  WHERE ID = i_ID ;

END;

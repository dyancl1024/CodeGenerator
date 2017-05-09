/*
  RH_Assessment - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Assessment_Detail;
CREATE  PROCEDURE sp_SJ_RH_Assessment_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     AName,
     ADesc,
     Status
  FROM RH_Assessment
  WHERE ID = i_ID ;

END;

/*
  RH_Assessment - 查看列表脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Assessment_Detail;
CREATE  PROCEDURE sp_SJ_RH_Assessment_Detail
(
   IN i_PageSize int,
   IN i_PageIndex int,
   OUT o_TotlaCount int
)
BEGIN

  SELECT COUNT(1) INTO o_TotlaCount FROM RH_Assessment;

  SELECT 
     ID,
     AName,
     ADesc,
     Status
   FROM RH_Assessment
   WHERE 1=1 
   LIMIT i_PageIndex,i_PageSize ;

END;

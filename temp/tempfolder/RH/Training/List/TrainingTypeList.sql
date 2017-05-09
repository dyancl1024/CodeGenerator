/*
  RH_TrainingType - 查看列表脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingType_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingType_Detail
(
   IN i_PageSize int,
   IN i_PageIndex int,
   OUT o_TotlaCount int
)
BEGIN

  SELECT COUNT(1) INTO o_TotlaCount FROM RH_TrainingType;

  SELECT 
     ID,
     Name,
     Code,
     Sort
   FROM RH_TrainingType
   WHERE 1=1 
   LIMIT i_PageIndex,i_PageSize ;

END;

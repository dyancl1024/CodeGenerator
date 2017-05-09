/*
  RH_TrainingStudyStatus - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingStudyStatus_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingStudyStatus_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     PCID,
     CID,
     SubTID,
     Status,
     UserID
  FROM RH_TrainingStudyStatus
  WHERE ID = i_ID ;

END;

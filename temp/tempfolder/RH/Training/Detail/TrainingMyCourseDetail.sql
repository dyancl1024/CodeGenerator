/*
  RH_TrainingMyCourse - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingMyCourse_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingMyCourse_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     SubTID,
     PCID,
     CID,
     UserID,
     CreateTime,
     Status
  FROM RH_TrainingMyCourse
  WHERE ID = i_ID ;

END;

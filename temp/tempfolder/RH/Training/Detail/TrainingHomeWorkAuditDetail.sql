/*
  RH_TrainingHomeWorkAudit - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingHomeWorkAudit_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingHomeWorkAudit_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     HomeWorkID,
     Auditor,
     AuditTime,
     AuditDesc,
     Status
  FROM RH_TrainingHomeWorkAudit
  WHERE ID = i_ID ;

END;

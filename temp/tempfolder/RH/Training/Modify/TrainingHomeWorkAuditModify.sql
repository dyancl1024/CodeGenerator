/*
  RH_TrainingHomeWorkAudit - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingHomeWorkAudit_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingHomeWorkAudit_Modify
(
   IN i_ID int,
   IN i_HomeWorkID int,
   IN i_Auditor int,
   IN i_AuditTime datetime,
   IN i_AuditDesc nvarchar(200),
   IN i_Status int,
   OUT o_Result int
)
BEGIN

  UPDATE RH_TrainingHomeWorkAudit
  SET
      HomeWorkID = i_HomeWorkID,
      Auditor = i_Auditor,
      AuditTime = i_AuditTime,
      AuditDesc = i_AuditDesc,
      Status = i_Status
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

/*
  RH_TrainingHomeWorkAudit - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingHomeWorkAudit_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingHomeWorkAudit_Add
(
   IN i_HomeWorkID int,
   IN i_Auditor int,
   IN i_AuditTime datetime,
   IN i_AuditDesc nvarchar(200),
   IN i_Status int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingHomeWorkAudit
  (
      HomeWorkID,
      Auditor,
      AuditTime,
      AuditDesc,
      Status
  )
  VALUES
  (
      i_HomeWorkID,  --  int (HomeWorkID)
      i_Auditor,  --  int (Auditor)
      i_AuditTime,  --  datetime (AuditTime)
      i_AuditDesc,  --  nvarchar(200) (审批意见)
      i_Status  --  int (作业状态：1.待提交 2.待审批 3.不合格 4.合格 5.优秀 -不合格时（待提交）)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

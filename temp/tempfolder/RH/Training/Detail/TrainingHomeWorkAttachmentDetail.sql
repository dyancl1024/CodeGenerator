/*
  RH_TrainingHomeWorkAttachment - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingHomeWorkAttachment_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingHomeWorkAttachment_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     HomeWorkID,
     AttachmentName,
     AttachmentUrl,
     AttachmentType,
     CreateBy,
     CreateTime
  FROM RH_TrainingHomeWorkAttachment
  WHERE ID = i_ID ;

END;

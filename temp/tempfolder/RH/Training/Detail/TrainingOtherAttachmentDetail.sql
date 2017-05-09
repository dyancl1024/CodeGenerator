/*
  RH_TrainingOtherAttachment - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingOtherAttachment_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingOtherAttachment_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     TOID,
     AttachmentName,
     AttachmentURL,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime
  FROM RH_TrainingOtherAttachment
  WHERE ID = i_ID ;

END;

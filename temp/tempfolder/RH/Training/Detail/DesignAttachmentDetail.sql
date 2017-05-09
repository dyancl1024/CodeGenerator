/*
  RH_DesignAttachment - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_DesignAttachment_Detail;
CREATE  PROCEDURE sp_SJ_RH_DesignAttachment_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     DesignID,
     AttachmentName,
     AttachmentUrl,
     AttachmentType,
     CreateBy,
     CreateTime
  FROM RH_DesignAttachment
  WHERE ID = i_ID ;

END;

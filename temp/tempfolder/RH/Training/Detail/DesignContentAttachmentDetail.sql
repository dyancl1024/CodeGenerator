/*
  RH_DesignContentAttachment - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_DesignContentAttachment_Detail;
CREATE  PROCEDURE sp_SJ_RH_DesignContentAttachment_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     DesignContentID,
     AttachementName,
     AttachmentUrl,
     Version,
     CreateBy,
     CreateTime
  FROM RH_DesignContentAttachment
  WHERE ID = i_ID ;

END;

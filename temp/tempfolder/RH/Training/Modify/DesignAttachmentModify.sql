/*
  RH_DesignAttachment - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_DesignAttachment_Modify;
CREATE  PROCEDURE sp_SJ_RH_DesignAttachment_Modify
(
   IN i_ID int,
   IN i_DesignID int,
   IN i_AttachmentName nvarchar(50),
   IN i_AttachmentUrl nvarchar(50),
   IN i_AttachmentType int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_DesignAttachment
  SET
      DesignID = i_DesignID,
      AttachmentName = i_AttachmentName,
      AttachmentUrl = i_AttachmentUrl,
      AttachmentType = i_AttachmentType,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

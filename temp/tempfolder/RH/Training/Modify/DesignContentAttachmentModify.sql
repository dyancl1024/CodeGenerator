/*
  RH_DesignContentAttachment - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_DesignContentAttachment_Modify;
CREATE  PROCEDURE sp_SJ_RH_DesignContentAttachment_Modify
(
   IN i_ID int,
   IN i_DesignContentID int,
   IN i_AttachementName nvarchar(50),
   IN i_AttachmentUrl nvarchar(50),
   IN i_Version varchar(50),
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_DesignContentAttachment
  SET
      DesignContentID = i_DesignContentID,
      AttachementName = i_AttachementName,
      AttachmentUrl = i_AttachmentUrl,
      Version = i_Version,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

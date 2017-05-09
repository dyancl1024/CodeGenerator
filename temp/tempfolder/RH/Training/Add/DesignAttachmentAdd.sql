/*
  RH_DesignAttachment - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_DesignAttachment_Add;
CREATE  PROCEDURE sp_SJ_RH_DesignAttachment_Add
(
   IN i_DesignID int,
   IN i_AttachmentName nvarchar(50),
   IN i_AttachmentUrl nvarchar(50),
   IN i_AttachmentType int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_DesignAttachment
  (
      DesignID,
      AttachmentName,
      AttachmentUrl,
      AttachmentType,
      CreateBy,
      CreateTime
  )
  VALUES
  (
      i_DesignID,  --  int (DesignID)
      i_AttachmentName,  --  nvarchar(50) (AttachmentName)
      i_AttachmentUrl,  --  nvarchar(50) (AttachmentUrl)
      i_AttachmentType,  --  int (AttachmentType)
      i_CreateBy,  --  int (CreateBy)
      i_CreateTime  --  datetime (CreateTime)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

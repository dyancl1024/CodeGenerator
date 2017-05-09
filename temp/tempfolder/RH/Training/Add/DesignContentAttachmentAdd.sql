/*
  RH_DesignContentAttachment - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_DesignContentAttachment_Add;
CREATE  PROCEDURE sp_SJ_RH_DesignContentAttachment_Add
(
   IN i_DesignContentID int,
   IN i_AttachementName nvarchar(50),
   IN i_AttachmentUrl nvarchar(50),
   IN i_Version varchar(50),
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_DesignContentAttachment
  (
      DesignContentID,
      AttachementName,
      AttachmentUrl,
      Version,
      CreateBy,
      CreateTime
  )
  VALUES
  (
      i_DesignContentID,  --  int (DesignContentID)
      i_AttachementName,  --  nvarchar(50) (AttachementName)
      i_AttachmentUrl,  --  nvarchar(50) (AttachmentUrl)
      i_Version,  --  varchar(50) (版本号：附件带版本号（系统自动编号），如：v1.0，2.0，按版本从高到低排序)
      i_CreateBy,  --  int (CreateBy)
      i_CreateTime  --  datetime (CreateTime)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

/*
  RH_CourseAttachment - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseAttachment_Add;
CREATE  PROCEDURE sp_SJ_RH_CourseAttachment_Add
(
   IN i_CourseID int,
   IN i_AttachmentName nvarchar(50),
   IN i_AttachmentUrl nvarchar(50),
   IN i_AttachmentType int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_CourseAttachment
  (
      CourseID,
      AttachmentName,
      AttachmentUrl,
      AttachmentType,
      CreateBy,
      CreateTime
  )
  VALUES
  (
      i_CourseID,  --  int (CourseID)
      i_AttachmentName,  --  nvarchar(50) (AttachmentName)
      i_AttachmentUrl,  --  nvarchar(50) (AttachmentUrl)
      i_AttachmentType,  --  int (AttachmentType)
      i_CreateBy,  --  int (CreateBy)
      i_CreateTime  --  datetime (CreateTime)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

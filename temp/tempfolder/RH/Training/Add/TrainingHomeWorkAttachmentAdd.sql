/*
  RH_TrainingHomeWorkAttachment - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingHomeWorkAttachment_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingHomeWorkAttachment_Add
(
   IN i_HomeWorkID int,
   IN i_AttachmentName nvarchar(50),
   IN i_AttachmentUrl nvarchar(50),
   IN i_AttachmentType int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingHomeWorkAttachment
  (
      HomeWorkID,
      AttachmentName,
      AttachmentUrl,
      AttachmentType,
      CreateBy,
      CreateTime
  )
  VALUES
  (
      i_HomeWorkID,  --  int (HomeWorkID)
      i_AttachmentName,  --  nvarchar(50) (AttachmentName)
      i_AttachmentUrl,  --  nvarchar(50) (AttachmentUrl)
      i_AttachmentType,  --  int (1-文本 2-视频 3-图片 4-音频)
      i_CreateBy,  --  int (CreateBy)
      i_CreateTime  --  datetime (CreateTime)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

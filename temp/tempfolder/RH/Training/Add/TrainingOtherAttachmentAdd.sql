/*
  RH_TrainingOtherAttachment - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingOtherAttachment_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingOtherAttachment_Add
(
   IN i_TOID int,
   IN i_AttachmentName nvarchar(200),
   IN i_AttachmentURL nvarchar(200),
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingOtherAttachment
  (
      TOID,
      AttachmentName,
      AttachmentURL,
      CreateBy,
      CreateTime,
      UpdateBy,
      UpdateTime
  )
  VALUES
  (
      i_TOID,  --  int (对应RH_TrainingOther表id)
      i_AttachmentName,  --  nvarchar(200) (AttachmentName)
      i_AttachmentURL,  --  nvarchar(200) (AttachmentURL)
      i_CreateBy,  --  int (CreateBy)
      i_CreateTime,  --  datetime (CreateTime)
      i_UpdateBy,  --  int (UpdateBy)
      i_UpdateTime  --  datetime (UpdateTime)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

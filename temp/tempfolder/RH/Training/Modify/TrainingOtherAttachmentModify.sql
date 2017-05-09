/*
  RH_TrainingOtherAttachment - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingOtherAttachment_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingOtherAttachment_Modify
(
   IN i_ID int,
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

  UPDATE RH_TrainingOtherAttachment
  SET
      TOID = i_TOID,
      AttachmentName = i_AttachmentName,
      AttachmentURL = i_AttachmentURL,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

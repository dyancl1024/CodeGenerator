/*
  RH_CourseAttachment - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseAttachment_Detail;
CREATE  PROCEDURE sp_SJ_RH_CourseAttachment_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     CourseID,
     AttachmentName,
     AttachmentUrl,
     AttachmentType,
     CreateBy,
     CreateTime
  FROM RH_CourseAttachment
  WHERE ID = i_ID ;

END;

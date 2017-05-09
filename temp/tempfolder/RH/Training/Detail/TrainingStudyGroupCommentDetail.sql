/*
  RH_TrainingStudyGroupComment - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingStudyGroupComment_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingStudyGroupComment_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     StudyGroupID,
     CommentTitile,
     Comment,
     IPAdress,
     ParentID,
     IsExpert,
     CreateBy,
     CreateTime
  FROM RH_TrainingStudyGroupComment
  WHERE ID = i_ID ;

END;

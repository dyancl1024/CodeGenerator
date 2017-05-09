/*
  RH_TrainingBriefingComment - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingBriefingComment_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingBriefingComment_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     TBID,
     Comment,
     IPAdress,
     ParentID,
     CreateBy,
     CreateTime
  FROM RH_TrainingBriefingComment
  WHERE ID = i_ID ;

END;

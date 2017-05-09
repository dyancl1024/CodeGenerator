/*
  RH_TrainingStudyGroup - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingStudyGroup_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingStudyGroup_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     StudyGroupName,
     SubTID,
     CID,
     Status,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime
  FROM RH_TrainingStudyGroup
  WHERE ID = i_ID ;

END;

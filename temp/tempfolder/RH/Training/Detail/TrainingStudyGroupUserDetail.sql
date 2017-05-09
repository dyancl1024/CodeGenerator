/*
  RH_TrainingStudyGroupUser - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingStudyGroupUser_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingStudyGroupUser_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     StudyGroupID,
     UserID,
     Status,
     CreateTime
  FROM RH_TrainingStudyGroupUser
  WHERE ID = i_ID ;

END;

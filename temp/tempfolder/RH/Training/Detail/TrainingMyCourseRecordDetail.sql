/*
  RH_TrainingMyCourseRecord - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingMyCourseRecord_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingMyCourseRecord_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     UserID,
     SubTID,
     PCID,
     CourseID,
     WatchTime,
     TotalWatchTime,
     CreateTime
  FROM RH_TrainingMyCourseRecord
  WHERE ID = i_ID ;

END;

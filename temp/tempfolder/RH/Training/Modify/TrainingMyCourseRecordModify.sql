/*
  RH_TrainingMyCourseRecord - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingMyCourseRecord_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingMyCourseRecord_Modify
(
   IN i_ID int,
   IN i_UserID int,
   IN i_SubTID int,
   IN i_PCID int,
   IN i_CourseID int,
   IN i_WatchTime int,
   IN i_TotalWatchTime int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_TrainingMyCourseRecord
  SET
      UserID = i_UserID,
      SubTID = i_SubTID,
      PCID = i_PCID,
      CourseID = i_CourseID,
      WatchTime = i_WatchTime,
      TotalWatchTime = i_TotalWatchTime,
      CreateTime = i_CreateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

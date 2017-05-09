/*
  RH_TrainingMyCourseRecord - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingMyCourseRecord_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingMyCourseRecord_Add
(
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

  INSERT INTO RH_TrainingMyCourseRecord
  (
      UserID,
      SubTID,
      PCID,
      CourseID,
      WatchTime,
      TotalWatchTime,
      CreateTime
  )
  VALUES
  (
      i_UserID,  --  int (人员ID)
      i_SubTID,  --  int (项目id)
      i_PCID,  --  int (套餐ID)
      i_CourseID,  --  int (课程id)
      i_WatchTime,  --  int (当前已观看时间)
      i_TotalWatchTime,  --  int (总共观看时间)
      i_CreateTime  --  datetime (CreateTime)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

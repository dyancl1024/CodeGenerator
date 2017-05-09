/*
  RH_TrainingMyCourse - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingMyCourse_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingMyCourse_Add
(
   IN i_SubTID int,
   IN i_PCID int,
   IN i_CID int,
   IN i_UserID int,
   IN i_CreateTime datetime,
   IN i_Status int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingMyCourse
  (
      SubTID,
      PCID,
      CID,
      UserID,
      CreateTime,
      Status
  )
  VALUES
  (
      i_SubTID,  --  int (项目id)
      i_PCID,  --  int (套餐id，对应课程预设表)
      i_CID,  --  int (课程id)
      i_UserID,  --  int (学员id)
      i_CreateTime,  --  datetime (选课时间)
      i_Status  --  int (选课状态：1.正常2.删除)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

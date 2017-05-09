/*
  RH_TrainingStudyGroupUser - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingStudyGroupUser_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingStudyGroupUser_Add
(
   IN i_StudyGroupID int,
   IN i_UserID int,
   IN i_Status int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingStudyGroupUser
  (
      StudyGroupID,
      UserID,
      Status,
      CreateTime
  )
  VALUES
  (
      i_StudyGroupID,  --  int (StudyGroupID)
      i_UserID,  --  int (UserID)
      i_Status,  --  int (1.正常2.删除)
      i_CreateTime  --  datetime (发布时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

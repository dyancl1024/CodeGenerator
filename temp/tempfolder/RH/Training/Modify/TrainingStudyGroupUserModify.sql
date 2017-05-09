/*
  RH_TrainingStudyGroupUser - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingStudyGroupUser_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingStudyGroupUser_Modify
(
   IN i_ID int,
   IN i_StudyGroupID int,
   IN i_UserID int,
   IN i_Status int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_TrainingStudyGroupUser
  SET
      StudyGroupID = i_StudyGroupID,
      UserID = i_UserID,
      Status = i_Status,
      CreateTime = i_CreateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

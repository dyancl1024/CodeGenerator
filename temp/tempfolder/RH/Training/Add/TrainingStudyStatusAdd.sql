/*
  RH_TrainingStudyStatus - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingStudyStatus_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingStudyStatus_Add
(
   IN i_PCID int,
   IN i_CID int,
   IN i_SubTID int,
   IN i_Status int,
   IN i_UserID int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingStudyStatus
  (
      PCID,
      CID,
      SubTID,
      Status,
      UserID
  )
  VALUES
  (
      i_PCID,  --  int (PCID)
      i_CID,  --  int (课程ID)
      i_SubTID,  --  int (SubTID)
      i_Status,  --  int (课程学习状态：1学习中2.完成学习)
      i_UserID  --  int (UserID)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

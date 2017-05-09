/*
  RH_TrainingStudyStatus - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingStudyStatus_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingStudyStatus_Modify
(
   IN i_ID int,
   IN i_PCID int,
   IN i_CID int,
   IN i_SubTID int,
   IN i_Status int,
   IN i_UserID int,
   OUT o_Result int
)
BEGIN

  UPDATE RH_TrainingStudyStatus
  SET
      PCID = i_PCID,
      CID = i_CID,
      SubTID = i_SubTID,
      Status = i_Status,
      UserID = i_UserID
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

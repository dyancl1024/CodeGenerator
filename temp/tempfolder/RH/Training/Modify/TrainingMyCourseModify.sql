/*
  RH_TrainingMyCourse - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingMyCourse_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingMyCourse_Modify
(
   IN i_ID int,
   IN i_SubTID int,
   IN i_PCID int,
   IN i_CID int,
   IN i_UserID int,
   IN i_CreateTime datetime,
   IN i_Status int,
   OUT o_Result int
)
BEGIN

  UPDATE RH_TrainingMyCourse
  SET
      SubTID = i_SubTID,
      PCID = i_PCID,
      CID = i_CID,
      UserID = i_UserID,
      CreateTime = i_CreateTime,
      Status = i_Status
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

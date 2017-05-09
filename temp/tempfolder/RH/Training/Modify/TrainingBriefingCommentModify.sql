/*
  RH_TrainingBriefingComment - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingBriefingComment_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingBriefingComment_Modify
(
   IN i_ID int,
   IN i_TBID int,
   IN i_Comment nvarchar(Max),
   IN i_IPAdress varchar(50),
   IN i_ParentID int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_TrainingBriefingComment
  SET
      TBID = i_TBID,
      Comment = i_Comment,
      IPAdress = i_IPAdress,
      ParentID = i_ParentID,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

/*
  RH_TrainingTeacherSummary - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingTeacherSummary_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingTeacherSummary_Modify
(
   IN i_ID int,
   IN i_TID int,
   IN i_SubTID int,
   IN i_Ttype int,
   IN i_TeacherSummaryTitle nvarchar(50),
   IN i_TeacherSummaryContent nvarchar(Max),
   IN i_StaticUrl nvarchar(200),
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_TrainingTeacherSummary
  SET
      TID = i_TID,
      SubTID = i_SubTID,
      Ttype = i_Ttype,
      TeacherSummaryTitle = i_TeacherSummaryTitle,
      TeacherSummaryContent = i_TeacherSummaryContent,
      StaticUrl = i_StaticUrl,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateTime = i_UpdateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

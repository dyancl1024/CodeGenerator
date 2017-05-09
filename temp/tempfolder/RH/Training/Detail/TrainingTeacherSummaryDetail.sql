/*
  RH_TrainingTeacherSummary - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingTeacherSummary_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingTeacherSummary_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     TID,
     SubTID,
     Ttype,
     TeacherSummaryTitle,
     TeacherSummaryContent,
     StaticUrl,
     CreateBy,
     CreateTime,
     UpdateTime
  FROM RH_TrainingTeacherSummary
  WHERE ID = i_ID ;

END;

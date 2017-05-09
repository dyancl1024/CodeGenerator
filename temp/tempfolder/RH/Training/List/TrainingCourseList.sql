/*
  RH_TrainingCourse - 查看列表脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingCourse_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingCourse_Detail
(
   IN i_PageSize int,
   IN i_PageIndex int,
   OUT o_TotlaCount int
)
BEGIN

  SELECT COUNT(1) INTO o_TotlaCount FROM RH_TrainingCourse;

  SELECT 
     ID,
     PresetID,
     SubTID,
     CourseID,
     IfRequired,
     CPharse,
     Sort,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime
   FROM RH_TrainingCourse
   WHERE 1=1 
   LIMIT i_PageIndex,i_PageSize ;

END;

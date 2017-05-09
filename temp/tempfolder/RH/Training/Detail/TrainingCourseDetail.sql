/*
  RH_TrainingCourse - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingCourse_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingCourse_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
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
  WHERE ID = i_ID ;

END;

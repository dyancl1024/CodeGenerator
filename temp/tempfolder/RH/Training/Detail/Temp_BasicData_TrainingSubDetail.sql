/*
  RH_Temp_BasicData_TrainingSub - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Temp_BasicData_TrainingSub_Detail;
CREATE  PROCEDURE sp_SJ_RH_Temp_BasicData_TrainingSub_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     tid,
     SubTID,
     TeacherNum,
     ClassNum,
     FinishedNum,
     StudyNum,
     UserNum,
     FinishedRate,
     StudyRate
  FROM RH_Temp_BasicData_TrainingSub
  WHERE ID = i_ID ;

END;

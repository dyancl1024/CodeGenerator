/*
  RH_Temp_BasicData_TrainingSub - 查看列表脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Temp_BasicData_TrainingSub_Detail;
CREATE  PROCEDURE sp_SJ_RH_Temp_BasicData_TrainingSub_Detail
(
   IN i_PageSize int,
   IN i_PageIndex int,
   OUT o_TotlaCount int
)
BEGIN

  SELECT COUNT(1) INTO o_TotlaCount FROM RH_Temp_BasicData_TrainingSub;

  SELECT 
     ID,
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
   WHERE 1=1 
   LIMIT i_PageIndex,i_PageSize ;

END;

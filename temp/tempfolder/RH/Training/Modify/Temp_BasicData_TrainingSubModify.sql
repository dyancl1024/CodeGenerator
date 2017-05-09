/*
  RH_Temp_BasicData_TrainingSub - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Temp_BasicData_TrainingSub_Modify;
CREATE  PROCEDURE sp_SJ_RH_Temp_BasicData_TrainingSub_Modify
(
   IN i_ID int,
   IN i_tid int,
   IN i_SubTID int,
   IN i_TeacherNum int,
   IN i_ClassNum int,
   IN i_FinishedNum int,
   IN i_StudyNum int,
   IN i_UserNum int,
   IN i_FinishedRate decimal(6,2),
   IN i_StudyRate decimal(6,2),
   OUT o_Result int
)
BEGIN

  UPDATE RH_Temp_BasicData_TrainingSub
  SET
      tid = i_tid,
      SubTID = i_SubTID,
      TeacherNum = i_TeacherNum,
      ClassNum = i_ClassNum,
      FinishedNum = i_FinishedNum,
      StudyNum = i_StudyNum,
      UserNum = i_UserNum,
      FinishedRate = i_FinishedRate,
      StudyRate = i_StudyRate
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

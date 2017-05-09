/*
  RH_Temp_BasicData_TrainingSub - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Temp_BasicData_TrainingSub_Add;
CREATE  PROCEDURE sp_SJ_RH_Temp_BasicData_TrainingSub_Add
(
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

  INSERT INTO RH_Temp_BasicData_TrainingSub
  (
      tid,
      SubTID,
      TeacherNum,
      ClassNum,
      FinishedNum,
      StudyNum,
      UserNum,
      FinishedRate,
      StudyRate
  )
  VALUES
  (
      i_tid,  --  int (tid)
      i_SubTID,  --  int (SubTID)
      i_TeacherNum,  --  int (TeacherNum)
      i_ClassNum,  --  int (班级数量)
      i_FinishedNum,  --  int (合格人数)
      i_StudyNum,  --  int (学习人数)
      i_UserNum,  --  int (学员总数)
      i_FinishedRate,  --  decimal(6,2) (合格率)
      i_StudyRate  --  decimal(6,2) (学习率)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

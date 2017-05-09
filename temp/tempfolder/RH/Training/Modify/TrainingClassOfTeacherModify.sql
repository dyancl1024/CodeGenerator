/*
  RH_TrainingClassOfTeacher - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingClassOfTeacher_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingClassOfTeacher_Modify
(
   IN i_ID int,
   IN i_SubTID int,
   IN i_ClassID int,
   IN i_TeacherID int,
   IN i_Appointer int,
   IN i_AppointTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_TrainingClassOfTeacher
  SET
      SubTID = i_SubTID,
      ClassID = i_ClassID,
      TeacherID = i_TeacherID,
      Appointer = i_Appointer,
      AppointTime = i_AppointTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

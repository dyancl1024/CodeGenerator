/*
  RH_TrainingClassOfTeacher - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingClassOfTeacher_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingClassOfTeacher_Add
(
   IN i_SubTID int,
   IN i_ClassID int,
   IN i_TeacherID int,
   IN i_Appointer int,
   IN i_AppointTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingClassOfTeacher
  (
      SubTID,
      ClassID,
      TeacherID,
      Appointer,
      AppointTime
  )
  VALUES
  (
      i_SubTID,  --  int (班级id  RH_Class)
      i_ClassID,  --  int (ClassID)
      i_TeacherID,  --  int (辅导老师id RH_User表)
      i_Appointer,  --  int (任命人 对应RH_User表id)
      i_AppointTime  --  datetime (任命时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

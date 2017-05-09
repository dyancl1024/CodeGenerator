/*
  RH_TrainingClassOfTeacher - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingClassOfTeacher_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingClassOfTeacher_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     SubTID,
     ClassID,
     TeacherID,
     Appointer,
     AppointTime
  FROM RH_TrainingClassOfTeacher
  WHERE ID = i_ID ;

END;

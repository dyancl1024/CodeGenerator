/*
  RH_TrainingTeacher - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingTeacher_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingTeacher_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     UserID,
     SubTID,
     CreateBy,
     CreateTime
  FROM RH_TrainingTeacher
  WHERE ID = i_ID ;

END;

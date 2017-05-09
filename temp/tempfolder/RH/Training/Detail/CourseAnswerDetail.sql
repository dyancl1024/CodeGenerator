/*
  RH_CourseAnswer - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseAnswer_Detail;
CREATE  PROCEDURE sp_SJ_RH_CourseAnswer_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     QuestionID,
     OptionID,
     IsRight,
     CreateBy,
     CreateTime
  FROM RH_CourseAnswer
  WHERE ID = i_ID ;

END;

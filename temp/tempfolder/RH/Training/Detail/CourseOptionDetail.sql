/*
  RH_CourseOption - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseOption_Detail;
CREATE  PROCEDURE sp_SJ_RH_CourseOption_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     QuestionID,
     QOption,
     Sort,
     IsRight
  FROM RH_CourseOption
  WHERE ID = i_ID ;

END;

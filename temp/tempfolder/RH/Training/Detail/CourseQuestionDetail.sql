/*
  RH_CourseQuestion - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseQuestion_Detail;
CREATE  PROCEDURE sp_SJ_RH_CourseQuestion_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     CourseID,
     Question,
     QType,
     Sort,
     Status,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime
  FROM RH_CourseQuestion
  WHERE ID = i_ID ;

END;

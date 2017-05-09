/*
  RH_Subject - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Subject_Detail;
CREATE  PROCEDURE sp_SJ_RH_Subject_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     SubjectName,
     SubCode,
     SubjectSort
  FROM RH_Subject
  WHERE ID = i_ID ;

END;

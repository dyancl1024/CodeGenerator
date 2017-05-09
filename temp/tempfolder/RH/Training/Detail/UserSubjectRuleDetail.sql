/*
  RH_UserSubjectRule - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_UserSubjectRule_Detail;
CREATE  PROCEDURE sp_SJ_RH_UserSubjectRule_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     UserID,
     GradeCode,
     SubjectCode,
     TID
  FROM RH_UserSubjectRule
  WHERE ID = i_ID ;

END;

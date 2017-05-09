/*
  RH_Subject - 查看列表脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Subject_Detail;
CREATE  PROCEDURE sp_SJ_RH_Subject_Detail
(
   IN i_PageSize int,
   IN i_PageIndex int,
   OUT o_TotlaCount int
)
BEGIN

  SELECT COUNT(1) INTO o_TotlaCount FROM RH_Subject;

  SELECT 
     ID,
     SubjectName,
     SubCode,
     SubjectSort
   FROM RH_Subject
   WHERE 1=1 
   LIMIT i_PageIndex,i_PageSize ;

END;

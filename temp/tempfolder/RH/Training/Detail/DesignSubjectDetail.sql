/*
  RH_DesignSubject - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_DesignSubject_Detail;
CREATE  PROCEDURE sp_SJ_RH_DesignSubject_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     DesignID,
     GradeCode,
     SubjectCode,
     CreateBy,
     CreateTime
  FROM RH_DesignSubject
  WHERE ID = i_ID ;

END;

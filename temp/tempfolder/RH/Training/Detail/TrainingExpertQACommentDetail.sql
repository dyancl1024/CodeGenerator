/*
  RH_TrainingExpertQAComment - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingExpertQAComment_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingExpertQAComment_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     QAID,
     Comment,
     IPAdress,
     ParentID,
     IsExpert,
     CreateBy,
     CreateTime
  FROM RH_TrainingExpertQAComment
  WHERE ID = i_ID ;

END;

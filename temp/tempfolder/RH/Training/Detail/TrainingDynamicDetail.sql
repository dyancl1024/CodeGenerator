/*
  RH_TrainingDynamic - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingDynamic_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingDynamic_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     ObjectID,
     MType,
     DyTitle,
     DyType,
     DyContent,
     DyLink,
     DyPicUrl,
     DState,
     CilckNum,
     StaticUrl,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime
  FROM RH_TrainingDynamic
  WHERE ID = i_ID ;

END;

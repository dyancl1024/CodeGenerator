/*
  RH_TrainingDynamic - 查看列表脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingDynamic_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingDynamic_Detail
(
   IN i_PageSize int,
   IN i_PageIndex int,
   OUT o_TotlaCount int
)
BEGIN

  SELECT COUNT(1) INTO o_TotlaCount FROM RH_TrainingDynamic;

  SELECT 
     ID,
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
   WHERE 1=1 
   LIMIT i_PageIndex,i_PageSize ;

END;

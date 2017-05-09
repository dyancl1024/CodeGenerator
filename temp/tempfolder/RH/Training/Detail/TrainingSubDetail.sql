/*
  RH_TrainingSub - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingSub_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingSub_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     TID,
     TName,
     TrainingNum,
     TrainingLevelCode,
     TrainingTypeCode,
     TMethod,
     IsGP,
     OrgCode,
     TrainingDateB,
     TrainingDateE,
     SignupRule,
     ClassRule,
     IsStage,
     TrainingUrl,
     TrainingHeadImg,
     StaticUrl,
     Status,
     AskTel,
     IsShowQQ,
     TestMethod,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime,
     Publisher,
     PublishDate
  FROM RH_TrainingSub
  WHERE ID = i_ID ;

END;

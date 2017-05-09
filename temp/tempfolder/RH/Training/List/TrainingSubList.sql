/*
  RH_TrainingSub - 查看列表脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingSub_Detail;
CREATE  PROCEDURE sp_SJ_RH_TrainingSub_Detail
(
   IN i_PageSize int,
   IN i_PageIndex int,
   OUT o_TotlaCount int
)
BEGIN

  SELECT COUNT(1) INTO o_TotlaCount FROM RH_TrainingSub;

  SELECT 
     ID,
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
   WHERE 1=1 
   LIMIT i_PageIndex,i_PageSize ;

END;

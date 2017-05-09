/*
  RH_Training - 查看列表脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Training_Detail;
CREATE  PROCEDURE sp_SJ_RH_Training_Detail
(
   IN i_PageSize int,
   IN i_PageIndex int,
   OUT o_TotlaCount int
)
BEGIN

  SELECT COUNT(1) INTO o_TotlaCount FROM RH_Training;

  SELECT 
     ID,
     DesignID,
     TName,
     TrainingPhase,
     TrainingNum,
     TrainingLevelCode,
     TrainingTypeCode,
     ProvinceID,
     CityID,
     DistrictID,
     TrainingDateB,
     TrainingDateE,
     IsStage,
     TrainingUrl,
     TrainingCode,
     TrainingHeadImg,
     StaticUrl,
     Status,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime,
     Publisher,
     PublishDate
   FROM RH_Training
   WHERE 1=1 
   LIMIT i_PageIndex,i_PageSize ;

END;

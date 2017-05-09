/*
  RH_Training - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Training_Detail;
CREATE  PROCEDURE sp_SJ_RH_Training_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
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
  WHERE ID = i_ID ;

END;

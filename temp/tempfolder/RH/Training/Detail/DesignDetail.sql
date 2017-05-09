/*
  RH_Design - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Design_Detail;
CREATE  PROCEDURE sp_SJ_RH_Design_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     DesignName,
     TrainingLevelCode,
     TrainingTypeCode,
     ProvinceID,
     CityID,
     DistrictID,
     OrgCode,
     TrainingNum,
     TrainingPhase,
     TrainingDateB,
     TrainingDateE,
     DesignDesc,
     Status,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime
  FROM RH_Design
  WHERE ID = i_ID ;

END;

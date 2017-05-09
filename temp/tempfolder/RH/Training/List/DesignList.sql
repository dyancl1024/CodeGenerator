/*
  RH_Design - 查看列表脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Design_Detail;
CREATE  PROCEDURE sp_SJ_RH_Design_Detail
(
   IN i_PageSize int,
   IN i_PageIndex int,
   OUT o_TotlaCount int
)
BEGIN

  SELECT COUNT(1) INTO o_TotlaCount FROM RH_Design;

  SELECT 
     ID,
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
   WHERE 1=1 
   LIMIT i_PageIndex,i_PageSize ;

END;

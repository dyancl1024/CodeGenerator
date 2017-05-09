/*
  RH_Design - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Design_Modify;
CREATE  PROCEDURE sp_SJ_RH_Design_Modify
(
   IN i_ID int,
   IN i_DesignName nvarchar(50),
   IN i_TrainingLevelCode varchar(50),
   IN i_TrainingTypeCode varchar(50),
   IN i_ProvinceID int,
   IN i_CityID int,
   IN i_DistrictID int,
   IN i_OrgCode varchar(50),
   IN i_TrainingNum int,
   IN i_TrainingPhase int,
   IN i_TrainingDateB datetime,
   IN i_TrainingDateE datetime,
   IN i_DesignDesc nvarchar(Max),
   IN i_Status int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_Design
  SET
      DesignName = i_DesignName,
      TrainingLevelCode = i_TrainingLevelCode,
      TrainingTypeCode = i_TrainingTypeCode,
      ProvinceID = i_ProvinceID,
      CityID = i_CityID,
      DistrictID = i_DistrictID,
      OrgCode = i_OrgCode,
      TrainingNum = i_TrainingNum,
      TrainingPhase = i_TrainingPhase,
      TrainingDateB = i_TrainingDateB,
      TrainingDateE = i_TrainingDateE,
      DesignDesc = i_DesignDesc,
      Status = i_Status,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

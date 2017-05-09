/*
  RH_Training - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Training_Modify;
CREATE  PROCEDURE sp_SJ_RH_Training_Modify
(
   IN i_ID int,
   IN i_DesignID int,
   IN i_TName nvarchar(200),
   IN i_TrainingPhase int,
   IN i_TrainingNum int,
   IN i_TrainingLevelCode varchar(50),
   IN i_TrainingTypeCode varchar(50),
   IN i_ProvinceID int,
   IN i_CityID int,
   IN i_DistrictID int,
   IN i_TrainingDateB datetime,
   IN i_TrainingDateE datetime,
   IN i_IsStage int,
   IN i_TrainingUrl varchar(200),
   IN i_TrainingCode varchar(50),
   IN i_TrainingHeadImg varchar(200),
   IN i_StaticUrl nvarchar(200),
   IN i_Status int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   IN i_Publisher int,
   IN i_PublishDate datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_Training
  SET
      DesignID = i_DesignID,
      TName = i_TName,
      TrainingPhase = i_TrainingPhase,
      TrainingNum = i_TrainingNum,
      TrainingLevelCode = i_TrainingLevelCode,
      TrainingTypeCode = i_TrainingTypeCode,
      ProvinceID = i_ProvinceID,
      CityID = i_CityID,
      DistrictID = i_DistrictID,
      TrainingDateB = i_TrainingDateB,
      TrainingDateE = i_TrainingDateE,
      IsStage = i_IsStage,
      TrainingUrl = i_TrainingUrl,
      TrainingCode = i_TrainingCode,
      TrainingHeadImg = i_TrainingHeadImg,
      StaticUrl = i_StaticUrl,
      Status = i_Status,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime,
      Publisher = i_Publisher,
      PublishDate = i_PublishDate
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

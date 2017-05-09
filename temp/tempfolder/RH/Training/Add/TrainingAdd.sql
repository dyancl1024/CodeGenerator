/*
  RH_Training - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Training_Add;
CREATE  PROCEDURE sp_SJ_RH_Training_Add
(
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

  INSERT INTO RH_Training
  (
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
  )
  VALUES
  (
      i_DesignID,  --  int (社区id)
      i_TName,  --  nvarchar(200) (项目名称)
      i_TrainingPhase,  --  int (学时)
      i_TrainingNum,  --  int (项目名称)
      i_TrainingLevelCode,  --  varchar(50) (承担机构id 对应表FJ_TrainingOrg的ID)
      i_TrainingTypeCode,  --  varchar(50) (TrainingTypeCode)
      i_ProvinceID,  --  int (ProvinceID)
      i_CityID,  --  int (CityID)
      i_DistrictID,  --  int (DistrictID)
      i_TrainingDateB,  --  datetime (时间安排起)
      i_TrainingDateE,  --  datetime (时间安排止)
      i_IsStage,  --  int (是否阶段项目 1 是 2 否)
      i_TrainingUrl,  --  varchar(200) (TrainingUrl)
      i_TrainingCode,  --  varchar(50) (项目编码)
      i_TrainingHeadImg,  --  varchar(200) (TrainingHeadImg)
      i_StaticUrl,  --  nvarchar(200) (StaticUrl)
      i_Status,  --  int (1.待实施(对应动作填写实施方案) 2.待配课（对应动作申请配课） 3.配课中（对应动作配课完成） 4.待发布（对应动作发布） 5.已发布 6.删除)
      i_CreateBy,  --  int (创建人)
      i_CreateTime,  --  datetime (创建时间)
      i_UpdateBy,  --  int (更新人)
      i_UpdateTime,  --  datetime (更新时间)
      i_Publisher,  --  int (发布人)
      i_PublishDate  --  datetime (发布时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

/*
  RH_Design - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Design_Add;
CREATE  PROCEDURE sp_SJ_RH_Design_Add
(
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

  INSERT INTO RH_Design
  (
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
  )
  VALUES
  (
      i_DesignName,  --  nvarchar(50) (社区id)
      i_TrainingLevelCode,  --  varchar(50) (承担机构id 对应表FJ_TrainingOrg的ID)
      i_TrainingTypeCode,  --  varchar(50) (TrainingTypeCode)
      i_ProvinceID,  --  int (ProvinceID)
      i_CityID,  --  int (CityID)
      i_DistrictID,  --  int (DistrictID)
      i_OrgCode,  --  varchar(50) (OrgCode)
      i_TrainingNum,  --  int (项目名称)
      i_TrainingPhase,  --  int (学时)
      i_TrainingDateB,  --  datetime (时间安排起)
      i_TrainingDateE,  --  datetime (时间安排止)
      i_DesignDesc,  --  nvarchar(Max) (DesignDesc)
      i_Status,  --  int (1.待审批（对应的动作提交审批） 2.审批中（对应的动作通过、不通过，） 3.已审批（对应的动作立项、不立项） 4.不通过（对应的动作提交审批） 5.立项（对应的动作分配教务） 6.不立项（对应的动作分配教务）)
      i_CreateBy,  --  int (创建人)
      i_CreateTime,  --  datetime (CreateTime)
      i_UpdateBy,  --  int (更新人)
      i_UpdateTime  --  datetime (UpdateTime)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

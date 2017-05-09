/*
  RH_TrainingDynamic - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingDynamic_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingDynamic_Modify
(
   IN i_ID int,
   IN i_ObjectID int,
   IN i_MType int,
   IN i_DyTitle nvarchar(100),
   IN i_DyType int,
   IN i_DyContent nvarchar(Max),
   IN i_DyLink nvarchar(200),
   IN i_DyPicUrl nvarchar(200),
   IN i_DState int,
   IN i_CilckNum int,
   IN i_StaticUrl nvarchar(200),
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_TrainingDynamic
  SET
      ObjectID = i_ObjectID,
      MType = i_MType,
      DyTitle = i_DyTitle,
      DyType = i_DyType,
      DyContent = i_DyContent,
      DyLink = i_DyLink,
      DyPicUrl = i_DyPicUrl,
      DState = i_DState,
      CilckNum = i_CilckNum,
      StaticUrl = i_StaticUrl,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

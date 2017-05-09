/*
  RH_Banner - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Banner_Modify;
CREATE  PROCEDURE sp_SJ_RH_Banner_Modify
(
   IN i_ID int,
   IN i_ADTitle nvarchar(200),
   IN i_AreaCode varchar(50),
   IN i_ADPhotoUrl nvarchar(200),
   IN i_ADContentType int,
   IN i_ADContentURL nvarchar(200),
   IN i_ADContent nvarchar(Max),
   IN i_Status int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_Banner
  SET
      ADTitle = i_ADTitle,
      AreaCode = i_AreaCode,
      ADPhotoUrl = i_ADPhotoUrl,
      ADContentType = i_ADContentType,
      ADContentURL = i_ADContentURL,
      ADContent = i_ADContent,
      Status = i_Status,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

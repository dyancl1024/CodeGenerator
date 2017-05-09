/*
  RH_Province - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Province_Modify;
CREATE  PROCEDURE sp_SJ_RH_Province_Modify
(
   IN i_ID int,
   IN i_ProvinceName nvarchar(50),
   IN i_ProvincePY varchar(50),
   IN i_CountyID int,
   IN i_Status int,
   OUT o_Result int
)
BEGIN

  UPDATE RH_Province
  SET
      ProvinceName = i_ProvinceName,
      ProvincePY = i_ProvincePY,
      CountyID = i_CountyID,
      Status = i_Status
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

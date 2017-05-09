/*
  RH_TempExcel - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TempExcel_Modify;
CREATE  PROCEDURE sp_SJ_RH_TempExcel_Modify
(
   IN i_ID int,
   IN i_FileExcel nvarchar(200),
   IN i_TableName nvarchar(200),
   IN i_TempRemark nvarchar(100),
   OUT o_Result int
)
BEGIN

  UPDATE RH_TempExcel
  SET
      FileExcel = i_FileExcel,
      TableName = i_TableName,
      TempRemark = i_TempRemark
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

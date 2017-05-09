/*
  RH_TempExcel - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TempExcel_Add;
CREATE  PROCEDURE sp_SJ_RH_TempExcel_Add
(
   IN i_FileExcel nvarchar(200),
   IN i_TableName nvarchar(200),
   IN i_TempRemark nvarchar(100),
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TempExcel
  (
      FileExcel,
      TableName,
      TempRemark
  )
  VALUES
  (
      i_FileExcel,  --  nvarchar(200) (FileExcel)
      i_TableName,  --  nvarchar(200) (TableName)
      i_TempRemark  --  nvarchar(100) (TempRemark)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

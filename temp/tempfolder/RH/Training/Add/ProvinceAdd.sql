/*
  RH_Province - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Province_Add;
CREATE  PROCEDURE sp_SJ_RH_Province_Add
(
   IN i_ProvinceName nvarchar(50),
   IN i_ProvincePY varchar(50),
   IN i_CountyID int,
   IN i_Status int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_Province
  (
      ProvinceName,
      ProvincePY,
      CountyID,
      Status
  )
  VALUES
  (
      i_ProvinceName,  --  nvarchar(50) (ProvinceName)
      i_ProvincePY,  --  varchar(50) (ProvincePY)
      i_CountyID,  --  int (CountyID)
      i_Status  --  int (Status)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

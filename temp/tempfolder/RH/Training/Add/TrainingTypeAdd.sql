/*
  RH_TrainingType - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingType_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingType_Add
(
   IN i_Name nvarchar(50),
   IN i_Code nvarchar(50),
   IN i_Sort int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingType
  (
      Name,
      Code,
      Sort
  )
  VALUES
  (
      i_Name,  --  nvarchar(50) (Name)
      i_Code,  --  nvarchar(50) (Code)
      i_Sort  --  int (Sort)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

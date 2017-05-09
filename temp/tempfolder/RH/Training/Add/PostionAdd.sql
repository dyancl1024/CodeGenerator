/*
  RH_Postion - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Postion_Add;
CREATE  PROCEDURE sp_SJ_RH_Postion_Add
(
   IN i_Name nvarchar(50),
   IN i_Code varchar(50),
   IN i_Sort int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_Postion
  (
      Name,
      Code,
      Sort
  )
  VALUES
  (
      i_Name,  --  nvarchar(50) (职位名称)
      i_Code,  --  varchar(50) (编号)
      i_Sort  --  int (顺序)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

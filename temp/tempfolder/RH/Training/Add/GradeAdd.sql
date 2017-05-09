/*
  RH_Grade - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Grade_Add;
CREATE  PROCEDURE sp_SJ_RH_Grade_Add
(
   IN i_Name nvarchar(50),
   IN i_Code varchar(50),
   IN i_Sort int,
   IN i_ParentID int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_Grade
  (
      Name,
      Code,
      Sort,
      ParentID
  )
  VALUES
  (
      i_Name,  --  nvarchar(50) (Name)
      i_Code,  --  varchar(50) (Code)
      i_Sort,  --  int (Sort)
      i_ParentID  --  int (0：大学段（如：小学） ，&lt;&gt;0:小学段（如小学1-6年级）)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

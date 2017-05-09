/*
  RH_CourseTheme - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseTheme_Add;
CREATE  PROCEDURE sp_SJ_RH_CourseTheme_Add
(
   IN i_Name nvarchar(50),
   IN i_Code varchar(50),
   IN i_Sort int,
   IN i_Type int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_CourseTheme
  (
      Name,
      Code,
      Sort,
      Type
  )
  VALUES
  (
      i_Name,  --  nvarchar(50) (Name)
      i_Code,  --  varchar(50) (Code)
      i_Sort,  --  int (Sort)
      i_Type  --  int (1.应用信息技术优化课堂教学  2.应用信息技术转变学习方式)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

/*
  RH_CourseCategory - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseCategory_Add;
CREATE  PROCEDURE sp_SJ_RH_CourseCategory_Add
(
   IN i_Name nvarchar(50),
   IN i_Code varchar(50),
   IN i_Type int,
   IN i_Sort int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_CourseCategory
  (
      Name,
      Code,
      Type,
      Sort
  )
  VALUES
  (
      i_Name,  --  nvarchar(50) (通识、技术、教研、科研、专业、技术素养、计划与准备、组织与管理、评估与诊断、组织与发展)
      i_Code,  --  varchar(50) (Code)
      i_Type,  --  int (课程类型：1非能力2能力)
      i_Sort  --  int (Sort)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

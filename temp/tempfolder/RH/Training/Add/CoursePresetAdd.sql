/*
  RH_CoursePreset - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CoursePreset_Add;
CREATE  PROCEDURE sp_SJ_RH_CoursePreset_Add
(
   IN i_Name nvarchar(50),
   IN i_CPDesc nvarchar(200),
   IN i_IfPromote int,
   IN i_IsRequired int,
   IN i_CourseLevel int,
   IN i_Dimension int,
   IN i_Version int,
   IN i_parentID int,
   IN i_Status int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_CoursePreset
  (
      Name,
      CPDesc,
      IfPromote,
      IsRequired,
      CourseLevel,
      Dimension,
      Version,
      parentID,
      Status,
      CreateBy,
      CreateTime,
      UpdateBy,
      UpdateTime
  )
  VALUES
  (
      i_Name,  --  nvarchar(50) (Name)
      i_CPDesc,  --  nvarchar(200) (CPDesc)
      i_IfPromote,  --  int (是否提升 1-是 0-否)
      i_IsRequired,  --  int (是否必修 1.是 2否)
      i_CourseLevel,  --  int (能力提升课程等级 1.初级 2.中级 3，高级)
      i_Dimension,  --  int (能力提升课程维度)
      i_Version,  --  int (版本号)
      i_parentID,  --  int (父套餐id，用于套餐复制)
      i_Status,  --  int (状态：1-未发布 2-已发布 3 已删除)
      i_CreateBy,  --  int (CreateBy)
      i_CreateTime,  --  datetime (CreateTime)
      i_UpdateBy,  --  int (UpdateBy)
      i_UpdateTime  --  datetime (UpdateTime)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

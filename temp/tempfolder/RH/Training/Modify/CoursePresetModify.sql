/*
  RH_CoursePreset - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CoursePreset_Modify;
CREATE  PROCEDURE sp_SJ_RH_CoursePreset_Modify
(
   IN i_ID int,
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

  UPDATE RH_CoursePreset
  SET
      Name = i_Name,
      CPDesc = i_CPDesc,
      IfPromote = i_IfPromote,
      IsRequired = i_IsRequired,
      CourseLevel = i_CourseLevel,
      Dimension = i_Dimension,
      Version = i_Version,
      parentID = i_parentID,
      Status = i_Status,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

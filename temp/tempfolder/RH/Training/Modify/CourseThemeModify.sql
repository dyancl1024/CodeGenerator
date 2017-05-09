/*
  RH_CourseTheme - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseTheme_Modify;
CREATE  PROCEDURE sp_SJ_RH_CourseTheme_Modify
(
   IN i_ID int,
   IN i_Name nvarchar(50),
   IN i_Code varchar(50),
   IN i_Sort int,
   IN i_Type int,
   OUT o_Result int
)
BEGIN

  UPDATE RH_CourseTheme
  SET
      Name = i_Name,
      Code = i_Code,
      Sort = i_Sort,
      Type = i_Type
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

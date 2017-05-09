/*
  RH_CourseQuestion - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseQuestion_Modify;
CREATE  PROCEDURE sp_SJ_RH_CourseQuestion_Modify
(
   IN i_ID int,
   IN i_CourseID int,
   IN i_Question nvarchar(200),
   IN i_QType int,
   IN i_Sort int,
   IN i_Status int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  UPDATE RH_CourseQuestion
  SET
      CourseID = i_CourseID,
      Question = i_Question,
      QType = i_QType,
      Sort = i_Sort,
      Status = i_Status,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

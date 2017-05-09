/*
  RH_CourseQuestion - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_CourseQuestion_Add;
CREATE  PROCEDURE sp_SJ_RH_CourseQuestion_Add
(
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

  INSERT INTO RH_CourseQuestion
  (
      CourseID,
      Question,
      QType,
      Sort,
      Status,
      CreateBy,
      CreateTime,
      UpdateBy,
      UpdateTime
  )
  VALUES
  (
      i_CourseID,  --  int (CourseID)
      i_Question,  --  nvarchar(200) (Question)
      i_QType,  --  int (1单选2多选3判断)
      i_Sort,  --  int (Sort)
      i_Status,  --  int (状态 1-未发布 2-已发布 3-删除)
      i_CreateBy,  --  int (创建人)
      i_CreateTime,  --  datetime (创建时间)
      i_UpdateBy,  --  int (更新人)
      i_UpdateTime  --  datetime (更新时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

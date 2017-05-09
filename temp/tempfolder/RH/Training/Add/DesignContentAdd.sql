/*
  RH_DesignContent - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_DesignContent_Add;
CREATE  PROCEDURE sp_SJ_RH_DesignContent_Add
(
   IN i_DesignID int,
   IN i_DType int,
   IN i_DName nvarchar(50),
   IN i_DContent nvarchar(Max),
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_DesignContent
  (
      DesignID,
      DType,
      DName,
      DContent,
      CreateBy,
      CreateTime,
      UpdateBy,
      UpdateTime
  )
  VALUES
  (
      i_DesignID,  --  int (DesignID)
      i_DType,  --  int (1.需求分析 2.目标定位 3.内容设计 4.培训阶段 5.培训方式 6.考核评价 7.管理服务 8.培训课程 9.项目标书)
      i_DName,  --  nvarchar(50) (1.需求分析 2.目标定位 3.内容设计 4.培训阶段 5.培训方式 6.考核评价 7.管理服务 8.培训课程 9.项目标书)
      i_DContent,  --  nvarchar(Max) (DContent)
      i_CreateBy,  --  int (CreateBy)
      i_CreateTime,  --  datetime (CreateTime)
      i_UpdateBy,  --  int (UpdateBy)
      i_UpdateTime  --  datetime (UpdateTime)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

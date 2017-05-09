/*
  RH_DesignContent - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_DesignContent_Modify;
CREATE  PROCEDURE sp_SJ_RH_DesignContent_Modify
(
   IN i_ID int,
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

  UPDATE RH_DesignContent
  SET
      DesignID = i_DesignID,
      DType = i_DType,
      DName = i_DName,
      DContent = i_DContent,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

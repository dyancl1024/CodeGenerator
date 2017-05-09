/*
  RH_DesignBusiness - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_DesignBusiness_Add;
CREATE  PROCEDURE sp_SJ_RH_DesignBusiness_Add
(
   IN i_DesignID int,
   IN i_UserID int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_DesignBusiness
  (
      DesignID,
      UserID,
      CreateBy,
      CreateTime
  )
  VALUES
  (
      i_DesignID,  --  int (DesignID)
      i_UserID,  --  int (UserID)
      i_CreateBy,  --  int (CreateBy)
      i_CreateTime  --  datetime (CreateTime)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

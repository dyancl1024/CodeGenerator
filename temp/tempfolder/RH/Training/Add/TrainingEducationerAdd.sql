/*
  RH_TrainingEducationer - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingEducationer_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingEducationer_Add
(
   IN i_DesignID int,
   IN i_UserID int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingEducationer
  (
      DesignID,
      UserID,
      CreateBy,
      CreateTime
  )
  VALUES
  (
      i_DesignID,  --  int (阶段项目id)
      i_UserID,  --  int (用户id)
      i_CreateBy,  --  int (CreateBy)
      i_CreateTime  --  datetime (CreateTime)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

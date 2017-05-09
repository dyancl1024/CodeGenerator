/*
  RH_TrainingTeacher - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingTeacher_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingTeacher_Add
(
   IN i_UserID int,
   IN i_SubTID int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingTeacher
  (
      UserID,
      SubTID,
      CreateBy,
      CreateTime
  )
  VALUES
  (
      i_UserID,  --  int (用户id)
      i_SubTID,  --  int (项目id)
      i_CreateBy,  --  int (导入人)
      i_CreateTime  --  datetime (导入时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

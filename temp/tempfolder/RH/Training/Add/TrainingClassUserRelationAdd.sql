/*
  RH_TrainingClassUserRelation - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingClassUserRelation_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingClassUserRelation_Add
(
   IN i_UserID int,
   IN i_ClassID int,
   IN i_SubTID int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingClassUserRelation
  (
      UserID,
      ClassID,
      SubTID,
      CreateBy,
      CreateTime,
      UpdateBy,
      UpdateTime
  )
  VALUES
  (
      i_UserID,  --  int (用户id)
      i_ClassID,  --  int (工作坊id（班级）)
      i_SubTID,  --  int (项目id)
      i_CreateBy,  --  int (导入人)
      i_CreateTime,  --  datetime (导入时间)
      i_UpdateBy,  --  int (更新人)
      i_UpdateTime  --  datetime (更新时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

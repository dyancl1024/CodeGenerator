/*
  RH_TrainingExcellent - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingExcellent_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingExcellent_Add
(
   IN i_TID int,
   IN i_UserID int,
   IN i_Ttype int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingExcellent
  (
      TID,
      UserID,
      Ttype,
      CreateBy,
      CreateTime,
      UpdateBy,
      UpdateTime
  )
  VALUES
  (
      i_TID,  --  int (TID)
      i_UserID,  --  int (UserID)
      i_Ttype,  --  int (项目评优表:1.学员2.辅导老师)
      i_CreateBy,  --  int (创建人)
      i_CreateTime,  --  datetime (创建时间)
      i_UpdateBy,  --  int (更新人)
      i_UpdateTime  --  datetime (更新时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

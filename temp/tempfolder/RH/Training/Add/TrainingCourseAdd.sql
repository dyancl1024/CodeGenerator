/*
  RH_TrainingCourse - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingCourse_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingCourse_Add
(
   IN i_PresetID int,
   IN i_SubTID int,
   IN i_CourseID int,
   IN i_IfRequired int,
   IN i_CPharse int,
   IN i_Sort int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingCourse
  (
      PresetID,
      SubTID,
      CourseID,
      IfRequired,
      CPharse,
      Sort,
      CreateBy,
      CreateTime,
      UpdateBy,
      UpdateTime
  )
  VALUES
  (
      i_PresetID,  --  int (预设ID)
      i_SubTID,  --  int (子项目ID)
      i_CourseID,  --  int (CourseID)
      i_IfRequired,  --  int (是否必修 1-是 0-否)
      i_CPharse,  --  int (课程学时)
      i_Sort,  --  int (Sort)
      i_CreateBy,  --  int (创建人)
      i_CreateTime,  --  datetime (创建时间)
      i_UpdateBy,  --  int (更新人)
      i_UpdateTime  --  datetime (更新时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

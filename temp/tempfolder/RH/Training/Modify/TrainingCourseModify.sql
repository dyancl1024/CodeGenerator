/*
  RH_TrainingCourse - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingCourse_Modify;
CREATE  PROCEDURE sp_SJ_RH_TrainingCourse_Modify
(
   IN i_ID int,
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

  UPDATE RH_TrainingCourse
  SET
      PresetID = i_PresetID,
      SubTID = i_SubTID,
      CourseID = i_CourseID,
      IfRequired = i_IfRequired,
      CPharse = i_CPharse,
      Sort = i_Sort,
      CreateBy = i_CreateBy,
      CreateTime = i_CreateTime,
      UpdateBy = i_UpdateBy,
      UpdateTime = i_UpdateTime
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

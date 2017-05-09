/*
  RH_TrainingStudyGroup - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingStudyGroup_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingStudyGroup_Add
(
   IN i_StudyGroupName nvarchar(50),
   IN i_SubTID int,
   IN i_CID int,
   IN i_Status int,
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateBy int,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingStudyGroup
  (
      StudyGroupName,
      SubTID,
      CID,
      Status,
      CreateBy,
      CreateTime,
      UpdateBy,
      UpdateTime
  )
  VALUES
  (
      i_StudyGroupName,  --  nvarchar(50) (学习小组名称)
      i_SubTID,  --  int (阶段项目ID)
      i_CID,  --  int (课程ID)
      i_Status,  --  int (状态：1.正常2.关闭)
      i_CreateBy,  --  int (创建人)
      i_CreateTime,  --  datetime (发布时间)
      i_UpdateBy,  --  int (更新人)
      i_UpdateTime  --  datetime (更新时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

/*
  RH_TrainingTeacherSummary - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TrainingTeacherSummary_Add;
CREATE  PROCEDURE sp_SJ_RH_TrainingTeacherSummary_Add
(
   IN i_TID int,
   IN i_SubTID int,
   IN i_Ttype int,
   IN i_TeacherSummaryTitle nvarchar(50),
   IN i_TeacherSummaryContent nvarchar(Max),
   IN i_StaticUrl nvarchar(200),
   IN i_CreateBy int,
   IN i_CreateTime datetime,
   IN i_UpdateTime datetime,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_TrainingTeacherSummary
  (
      TID,
      SubTID,
      Ttype,
      TeacherSummaryTitle,
      TeacherSummaryContent,
      StaticUrl,
      CreateBy,
      CreateTime,
      UpdateTime
  )
  VALUES
  (
      i_TID,  --  int (总项目id)
      i_SubTID,  --  int (阶段项目id)
      i_Ttype,  --  int (总结类型：1.辅导老师工作总结 2.项目总结（挂在总项目下，教务的操作）)
      i_TeacherSummaryTitle,  --  nvarchar(50) (TeacherSummaryTitle)
      i_TeacherSummaryContent,  --  nvarchar(Max) (TeacherSummaryContent)
      i_StaticUrl,  --  nvarchar(200) (静态访问地址)
      i_CreateBy,  --  int (创建人)
      i_CreateTime,  --  datetime (发布时间)
      i_UpdateTime  --  datetime (更新时间)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

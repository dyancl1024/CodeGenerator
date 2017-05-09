/*
  RH_Temp_BasicData_Class - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Temp_BasicData_Class_Add;
CREATE  PROCEDURE sp_SJ_RH_Temp_BasicData_Class_Add
(
   IN i_SubTID int,
   IN i_ClassID int,
   IN i_YX_HW int,
   IN i_TJ_HW int,
   IN i_StudyNum int,
   IN i_FinishedNum int,
   IN i_UserNum int,
   IN i_ClassRate decimal(7,3),
   IN i_HG_HW int,
   IN i_No_Num int,
   OUT o_Result int
)
BEGIN

  INSERT INTO RH_Temp_BasicData_Class
  (
      SubTID,
      ClassID,
      YX_HW,
      TJ_HW,
      StudyNum,
      FinishedNum,
      UserNum,
      ClassRate,
      HG_HW,
      No_Num
  )
  VALUES
  (
      i_SubTID,  --  int (SubTID)
      i_ClassID,  --  int (ClassID)
      i_YX_HW,  --  int (优秀作业数量)
      i_TJ_HW,  --  int (提交作业数量)
      i_StudyNum,  --  int (学习人数)
      i_FinishedNum,  --  int (合格的人数)
      i_UserNum,  --  int (班级人数)
      i_ClassRate,  --  decimal(7,3) (班级合格率)
      i_HG_HW,  --  int (合格作业数量（审批状态为合格和优秀）)
      i_No_Num  --  int (未审批作业数)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

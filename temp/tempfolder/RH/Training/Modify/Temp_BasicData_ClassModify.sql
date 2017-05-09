/*
  RH_Temp_BasicData_Class - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Temp_BasicData_Class_Modify;
CREATE  PROCEDURE sp_SJ_RH_Temp_BasicData_Class_Modify
(
   IN i_ID int,
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

  UPDATE RH_Temp_BasicData_Class
  SET
      SubTID = i_SubTID,
      ClassID = i_ClassID,
      YX_HW = i_YX_HW,
      TJ_HW = i_TJ_HW,
      StudyNum = i_StudyNum,
      FinishedNum = i_FinishedNum,
      UserNum = i_UserNum,
      ClassRate = i_ClassRate,
      HG_HW = i_HG_HW,
      No_Num = i_No_Num
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

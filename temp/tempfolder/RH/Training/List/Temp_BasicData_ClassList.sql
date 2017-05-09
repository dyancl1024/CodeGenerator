/*
  RH_Temp_BasicData_Class - 查看列表脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Temp_BasicData_Class_Detail;
CREATE  PROCEDURE sp_SJ_RH_Temp_BasicData_Class_Detail
(
   IN i_PageSize int,
   IN i_PageIndex int,
   OUT o_TotlaCount int
)
BEGIN

  SELECT COUNT(1) INTO o_TotlaCount FROM RH_Temp_BasicData_Class;

  SELECT 
     ID,
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
   FROM RH_Temp_BasicData_Class
   WHERE 1=1 
   LIMIT i_PageIndex,i_PageSize ;

END;

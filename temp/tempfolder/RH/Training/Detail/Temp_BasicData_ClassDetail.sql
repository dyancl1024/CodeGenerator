/*
  RH_Temp_BasicData_Class - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Temp_BasicData_Class_Detail;
CREATE  PROCEDURE sp_SJ_RH_Temp_BasicData_Class_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
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
  WHERE ID = i_ID ;

END;

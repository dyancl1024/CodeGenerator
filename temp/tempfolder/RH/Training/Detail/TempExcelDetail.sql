/*
  RH_TempExcel - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TempExcel_Detail;
CREATE  PROCEDURE sp_SJ_RH_TempExcel_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     FileExcel,
     TableName,
     TempRemark
  FROM RH_TempExcel
  WHERE ID = i_ID ;

END;

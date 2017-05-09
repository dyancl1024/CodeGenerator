/*
  RH_Org - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Org_Modify;
CREATE  PROCEDURE sp_SJ_RH_Org_Modify
(
   IN i_ID int,
   IN i_Name nvarchar(50),
   IN i_Code varchar(50),
   IN i_Sort int,
   IN i_Status int,
   OUT o_Result int
)
BEGIN

  UPDATE RH_Org
  SET
      Name = i_Name,
      Code = i_Code,
      Sort = i_Sort,
      Status = i_Status
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

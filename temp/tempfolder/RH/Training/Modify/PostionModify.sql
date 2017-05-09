/*
  RH_Postion - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Postion_Modify;
CREATE  PROCEDURE sp_SJ_RH_Postion_Modify
(
   IN i_ID int,
   IN i_Name nvarchar(50),
   IN i_Code varchar(50),
   IN i_Sort int,
   OUT o_Result int
)
BEGIN

  UPDATE RH_Postion
  SET
      Name = i_Name,
      Code = i_Code,
      Sort = i_Sort
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

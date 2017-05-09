/*
  RH_Assessment - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Assessment_Modify;
CREATE  PROCEDURE sp_SJ_RH_Assessment_Modify
(
   IN i_ID int,
   IN i_AName nvarchar(200),
   IN i_ADesc nvarchar(Max),
   IN i_Status int,
   OUT o_Result int
)
BEGIN

  UPDATE RH_Assessment
  SET
      AName = i_AName,
      ADesc = i_ADesc,
      Status = i_Status
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

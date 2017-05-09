/*
  RH_TempUser - 删除信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TempUser_Remove;
CREATE  PROCEDURE sp_SJ_RH_TempUser_Remove
(
   IN i_id int,
   OUT o_Result int
)
BEGIN

  DELETE FROM RH_TempUser WHERE id = i_id ;

  SELECT ROW_COUNT() INTO o_Result;

END;

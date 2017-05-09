/*
  RH_User - 删除信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_User_Remove;
CREATE  PROCEDURE sp_SJ_RH_User_Remove
(
   IN i_id int,
   OUT o_Result int
)
BEGIN

  DELETE FROM RH_User WHERE id = i_id ;

  SELECT ROW_COUNT() INTO o_Result;

END;

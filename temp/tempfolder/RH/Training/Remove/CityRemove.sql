/*
  RH_City - 删除信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_City_Remove;
CREATE  PROCEDURE sp_SJ_RH_City_Remove
(
   IN i_id int,
   OUT o_Result int
)
BEGIN

  DELETE FROM RH_City WHERE id = i_id ;

  SELECT ROW_COUNT() INTO o_Result;

END;

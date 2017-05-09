/*
  RH_Province - 删除信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Province_Remove;
CREATE  PROCEDURE sp_SJ_RH_Province_Remove
(
   IN i_ID int,
   OUT o_Result int
)
BEGIN

  DELETE FROM RH_Province WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

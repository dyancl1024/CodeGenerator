/*
  RH_MngUser - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_MngUser_Detail;
CREATE  PROCEDURE sp_SJ_RH_MngUser_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     UserName,
     Password,
     TrueName,
     RoleID,
     Status,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime
  FROM RH_MngUser
  WHERE ID = i_ID ;

END;

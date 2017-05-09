/*
  RH_UserInfo - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_UserInfo_Detail;
CREATE  PROCEDURE sp_SJ_RH_UserInfo_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
     UserID,
     SchoolID,
     CUserName,
     CPassword,
     CSource
  FROM RH_UserInfo
  WHERE ID = i_ID ;

END;

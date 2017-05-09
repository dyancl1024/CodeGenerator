/*
  RH_UserInfo - 查看列表脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_UserInfo_Detail;
CREATE  PROCEDURE sp_SJ_RH_UserInfo_Detail
(
   IN i_PageSize int,
   IN i_PageIndex int,
   OUT o_TotlaCount int
)
BEGIN

  SELECT COUNT(1) INTO o_TotlaCount FROM RH_UserInfo;

  SELECT 
     ID,
     UserID,
     SchoolID,
     CUserName,
     CPassword,
     CSource
   FROM RH_UserInfo
   WHERE 1=1 
   LIMIT i_PageIndex,i_PageSize ;

END;

/*
  RH_User - 查看列表脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_User_Detail;
CREATE  PROCEDURE sp_SJ_RH_User_Detail
(
   IN i_PageSize int,
   IN i_PageIndex int,
   OUT o_TotlaCount int
)
BEGIN

  SELECT COUNT(1) INTO o_TotlaCount FROM RH_User;

  SELECT 
     id,
     UserName,
     Password,
     TrueName,
     Gender,
     PicUrl,
     Nation,
     IDNO,
     ProvinceID,
     CityID,
     DistrictID,
     Mobile,
     Email,
     QQ,
     IPAddr,
     IsChange,
     UserState,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime
   FROM RH_User
   WHERE 1=1 
   LIMIT i_PageIndex,i_PageSize ;

END;

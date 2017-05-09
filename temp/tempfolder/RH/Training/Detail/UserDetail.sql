/*
  RH_User - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_User_Detail;
CREATE  PROCEDURE sp_SJ_RH_User_Detail
(
   IN i_id int
)
BEGIN

  SELECT 
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
  WHERE id = i_id ;

END;

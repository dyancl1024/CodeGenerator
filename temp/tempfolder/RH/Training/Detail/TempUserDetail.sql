/*
  RH_TempUser - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TempUser_Detail;
CREATE  PROCEDURE sp_SJ_RH_TempUser_Detail
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
     UpdateTime,
     CUserName,
     CPassword,
     GradeCode,
     SubjectCode,
     SchoolID,
     SchoolName,
     TempRemark,
     TempUserID,
     TempClassName,
     TempClassID
  FROM RH_TempUser
  WHERE id = i_id ;

END;

/*
  RH_TempUser - 查看列表脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_TempUser_Detail;
CREATE  PROCEDURE sp_SJ_RH_TempUser_Detail
(
   IN i_PageSize int,
   IN i_PageIndex int,
   OUT o_TotlaCount int
)
BEGIN

  SELECT COUNT(1) INTO o_TotlaCount FROM RH_TempUser;

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
   WHERE 1=1 
   LIMIT i_PageIndex,i_PageSize ;

END;

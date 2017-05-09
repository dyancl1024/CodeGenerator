/*
  RH_Temp_BasicData_User - 查看列表脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Temp_BasicData_User_Detail;
CREATE  PROCEDURE sp_SJ_RH_Temp_BasicData_User_Detail
(
   IN i_PageSize int,
   IN i_PageIndex int,
   OUT o_TotlaCount int
)
BEGIN

  SELECT COUNT(1) INTO o_TotlaCount FROM RH_Temp_BasicData_User;

  SELECT 
     ID,
     SubTID,
     ClassID,
     UserID,
     Phase,
     Q_jxfs,
     T_jxfs,
     F_jxfs,
     E_jxfs,
     Q_jxcl,
     T_jxcl,
     F_jxcl,
     E_jxcl,
     Q_xxxd,
     T_xxxd,
     F_xxxd,
     E_xxxd,
     Q_wtfx,
     T_wtfx,
     F_wtfx,
     E_wtfx,
     Q_yxrz,
     T_yxrz,
     F_yxrz,
     E_yxrz,
     Q_pxzj,
     T_pxzj,
     F_pxzj,
     E_pxzj,
     Finished,
     GetCoursePhase,
     CoursePhase,
     StatusName,
     IsStudy,
     HomeWorkPhase
   FROM RH_Temp_BasicData_User
   WHERE 1=1 
   LIMIT i_PageIndex,i_PageSize ;

END;

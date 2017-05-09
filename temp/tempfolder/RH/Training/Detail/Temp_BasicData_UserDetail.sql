/*
  RH_Temp_BasicData_User - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Temp_BasicData_User_Detail;
CREATE  PROCEDURE sp_SJ_RH_Temp_BasicData_User_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
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
  WHERE ID = i_ID ;

END;

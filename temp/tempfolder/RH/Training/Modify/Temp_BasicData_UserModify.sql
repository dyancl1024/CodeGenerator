/*
  RH_Temp_BasicData_User - 修改信息脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Temp_BasicData_User_Modify;
CREATE  PROCEDURE sp_SJ_RH_Temp_BasicData_User_Modify
(
   IN i_ID int,
   IN i_SubTID int,
   IN i_ClassID int,
   IN i_UserID int,
   IN i_Phase int,
   IN i_Q_jxfs int,
   IN i_T_jxfs int,
   IN i_F_jxfs int,
   IN i_E_jxfs int,
   IN i_Q_jxcl int,
   IN i_T_jxcl int,
   IN i_F_jxcl int,
   IN i_E_jxcl int,
   IN i_Q_xxxd int,
   IN i_T_xxxd int,
   IN i_F_xxxd int,
   IN i_E_xxxd int,
   IN i_Q_wtfx int,
   IN i_T_wtfx int,
   IN i_F_wtfx int,
   IN i_E_wtfx int,
   IN i_Q_yxrz int,
   IN i_T_yxrz int,
   IN i_F_yxrz int,
   IN i_E_yxrz int,
   IN i_Q_pxzj int,
   IN i_T_pxzj int,
   IN i_F_pxzj int,
   IN i_E_pxzj int,
   IN i_Finished int,
   IN i_GetCoursePhase int,
   IN i_CoursePhase int,
   IN i_StatusName nvarchar(10),
   IN i_IsStudy int,
   IN i_HomeWorkPhase int,
   OUT o_Result int
)
BEGIN

  UPDATE RH_Temp_BasicData_User
  SET
      SubTID = i_SubTID,
      ClassID = i_ClassID,
      UserID = i_UserID,
      Phase = i_Phase,
      Q_jxfs = i_Q_jxfs,
      T_jxfs = i_T_jxfs,
      F_jxfs = i_F_jxfs,
      E_jxfs = i_E_jxfs,
      Q_jxcl = i_Q_jxcl,
      T_jxcl = i_T_jxcl,
      F_jxcl = i_F_jxcl,
      E_jxcl = i_E_jxcl,
      Q_xxxd = i_Q_xxxd,
      T_xxxd = i_T_xxxd,
      F_xxxd = i_F_xxxd,
      E_xxxd = i_E_xxxd,
      Q_wtfx = i_Q_wtfx,
      T_wtfx = i_T_wtfx,
      F_wtfx = i_F_wtfx,
      E_wtfx = i_E_wtfx,
      Q_yxrz = i_Q_yxrz,
      T_yxrz = i_T_yxrz,
      F_yxrz = i_F_yxrz,
      E_yxrz = i_E_yxrz,
      Q_pxzj = i_Q_pxzj,
      T_pxzj = i_T_pxzj,
      F_pxzj = i_F_pxzj,
      E_pxzj = i_E_pxzj,
      Finished = i_Finished,
      GetCoursePhase = i_GetCoursePhase,
      CoursePhase = i_CoursePhase,
      StatusName = i_StatusName,
      IsStudy = i_IsStudy,
      HomeWorkPhase = i_HomeWorkPhase
  WHERE ID = i_ID ;

  SELECT ROW_COUNT() INTO o_Result;

END;

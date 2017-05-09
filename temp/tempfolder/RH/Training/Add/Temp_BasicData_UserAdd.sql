/*
  RH_Temp_BasicData_User - 新增脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Temp_BasicData_User_Add;
CREATE  PROCEDURE sp_SJ_RH_Temp_BasicData_User_Add
(
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

  INSERT INTO RH_Temp_BasicData_User
  (
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
  )
  VALUES
  (
      i_SubTID,  --  int (SubTID)
      i_ClassID,  --  int (ClassID)
      i_UserID,  --  int (UserID)
      i_Phase,  --  int (获得作业学时)
      i_Q_jxfs,  --  int (Q_jxfs)
      i_T_jxfs,  --  int (T_jxfs)
      i_F_jxfs,  --  int (F_jxfs)
      i_E_jxfs,  --  int (E_jxfs)
      i_Q_jxcl,  --  int (Q_jxcl)
      i_T_jxcl,  --  int (T_jxcl)
      i_F_jxcl,  --  int (F_jxcl)
      i_E_jxcl,  --  int (E_jxcl)
      i_Q_xxxd,  --  int (Q_xxxd)
      i_T_xxxd,  --  int (T_xxxd)
      i_F_xxxd,  --  int (F_xxxd)
      i_E_xxxd,  --  int (E_xxxd)
      i_Q_wtfx,  --  int (Q_wtfx)
      i_T_wtfx,  --  int (T_wtfx)
      i_F_wtfx,  --  int (F_wtfx)
      i_E_wtfx,  --  int (E_wtfx)
      i_Q_yxrz,  --  int (Q_yxrz)
      i_T_yxrz,  --  int (T_yxrz)
      i_F_yxrz,  --  int (F_yxrz)
      i_E_yxrz,  --  int (E_yxrz)
      i_Q_pxzj,  --  int (Q_pxzj)
      i_T_pxzj,  --  int (T_pxzj)
      i_F_pxzj,  --  int (F_pxzj)
      i_E_pxzj,  --  int (E_pxzj)
      i_Finished,  --  int (作业是否完成)
      i_GetCoursePhase,  --  int (获得课程学时)
      i_CoursePhase,  --  int (课程总学时)
      i_StatusName,  --  nvarchar(10) (培训状态)
      i_IsStudy,  --  int (是否学习)
      i_HomeWorkPhase  --  int (作业总学时)
   );

   SELECT @@IDENTITY INTO o_Result;

END;

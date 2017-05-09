/*
  RH_Course - 查看列表脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Course_Detail;
CREATE  PROCEDURE sp_SJ_RH_Course_Detail
(
   IN i_PageSize int,
   IN i_PageIndex int,
   OUT o_TotlaCount int
)
BEGIN

  SELECT COUNT(1) INTO o_TotlaCount FROM RH_Course;

  SELECT 
     ID,
     CourseName,
     CoursePharse,
     CourseCategoryCode,
     CourseDesc,
     CourseUrl,
     TeacherDesc,
     TeacherName,
     TeacherTitle,
     CourseLabel,
     CourseCode,
     IsPractice,
     CourseCompany,
     CourseStyle,
     IsSpecialTeacher,
     VideoDuration,
     IsApp,
     Status,
     CreateBy,
     CreateTime,
     UpdateBy,
     UpdateTime
   FROM RH_Course
   WHERE 1=1 
   LIMIT i_PageIndex,i_PageSize ;

END;

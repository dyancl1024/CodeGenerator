/*
  RH_Course - 查看详情脚本
*/
DROP PROCEDURE IF EXISTS sp_SJ_RH_Course_Detail;
CREATE  PROCEDURE sp_SJ_RH_Course_Detail
(
   IN i_ID int
)
BEGIN

  SELECT 
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
  WHERE ID = i_ID ;

END;

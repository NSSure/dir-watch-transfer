var gulp = require('gulp');

gulp.task('default', function () {
  return gulp.src('node_modules/thanatos-css/css/thanatos.css').pipe(gulp.dest('./dist/css'));
});

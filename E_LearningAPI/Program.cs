using E_LearningBL;
using E_LearningDAL;
using E_LearningDAL.Data.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<E_LearningAppContext>(option =>
                option.UseSqlServer("Server=.;Database=E_Learning2db;Trusted_Connection=True;Encrypt=False"));


builder.Services.AddScoped<IStudentRepo, StudentRepo>();
builder.Services.AddScoped<ICouresRepo, CourseRepo>();
builder.Services.AddScoped<IModuleRepo, ModuleRepo>();
builder.Services.AddScoped<ILessonRepo, LessonRepo>();
builder.Services.AddScoped<IQuizRepo, QuizRepo>();
builder.Services.AddScoped<IEnrollmentRepo, EnrollmentRepo>();
builder.Services.AddScoped<ICertificateRepo, CertificateRepo>();
builder.Services.AddScoped<IInstractorRepo, InstractorRepo>();
builder.Services.AddScoped<IStudentsQuizesRepo, StudentsQuizesRepo>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();



builder.Services.AddScoped<IStudentManager, StudentManager>();
builder.Services.AddScoped<ICourseManger, CourseManger>();
builder.Services.AddScoped<IEnrollmentManger, EnrollmentManger>();
builder.Services.AddScoped<IInstractorManger, InstractorManger>();
builder.Services.AddScoped<IQuizManager, QuizManager>();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

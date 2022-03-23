using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITMO.ASP.NET_Final.Models
{
	public class AllDbInitializer : DropCreateDatabaseIfModelChanges<AllDbContext>
	{
		protected override void Seed(AllDbContext context)
		{
			context.Students.Add(new Student { StudentName = "Дмитрий Тетерук" });
			context.Students.Add(new Student { StudentName = "Иван Иванов" });
			context.Students.Add(new Student { StudentName = "Петр Петров" });

			context.Disciplines.Add(new Discipline { DisciplineName = "ASP.NET" });
			context.Disciplines.Add(new Discipline { DisciplineName = "HTML/XML" });
			context.Disciplines.Add(new Discipline { DisciplineName = "C#" });
			context.Disciplines.Add(new Discipline { DisciplineName = "ADO.NET" });

			context.Scores.Add(new Scores { Discipline = "ADO.NET", Score = 5, ScoreDate = DateTime.Now, StudentName = "Дмитрий Тетерук" });
			context.Scores.Add(new Scores { Discipline = "HTML/XML", Score = 5, ScoreDate = DateTime.Now, StudentName = "Дмитрий Тетерук" });
			context.Scores.Add(new Scores { Discipline = "ASP.NET", Score = 5, ScoreDate = DateTime.Now, StudentName = "Дмитрий Тетерук" });
			context.Scores.Add(new Scores { Discipline = "ASP.NET", Score = 4, ScoreDate = DateTime.Now, StudentName = "Петр Петров" });
			context.Scores.Add(new Scores { Discipline = "HTML/XML", Score = 4, ScoreDate = DateTime.Now, StudentName = "Петр Петров" });
			context.Scores.Add(new Scores { Discipline = "HTML/XML", Score = 3, ScoreDate = DateTime.Now, StudentName = "Иван Иванов" });
			context.Scores.Add(new Scores { Discipline = "C#", Score = 3, ScoreDate = DateTime.Now, StudentName = "Иван Иванов" });


			base.Seed(context);
		}
	}
}
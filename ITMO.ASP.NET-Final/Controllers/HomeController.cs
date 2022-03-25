using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITMO.ASP.NET_Final.Models;
using ITMO.ASP.NET_Final.Controllers;
using System.Data.Entity;
using System.IO;
using System.Text;
using System.Net.Http.Headers;
using Rotativa;

namespace ITMO.ASP.NET_Final.Controllers
{
	public class HomeController : Controller
	{
		
		
		private AllDbContext db = new AllDbContext(); // экземпляр контекста данных для работы с БД

		[AllowAnonymous]
		public ActionResult Index()
		{
			// страница со всеми студентами и их отметками по всем предметам
			// из базы Scores
			ViewScores(); 
			return View();
		}

		public ActionResult Students()
		{
			// список всех студентов
			ViewStudents();
			return View();
		}

		// список всех дисциплин
		public ActionResult Disciplines()
		{
			ViewDisciplines();
			return View();
		}

		// подсчет баллов ВСЕХ студентов
		private void StudentsBySumOfScore()
		{
			List<SumScore> scoreSum = db.Scores
				.GroupBy(s => s.StudentName)
				.Select(scoresByStudent => new SumScore
				{
					StName = scoresByStudent.Key,
					Summ = scoresByStudent.Sum(s => s.Score)
				})
				.OrderByDescending(s => s.Summ)
				.ToList();
			
			ViewBag.Sum = scoreSum;
		}

		// подсчет баллов ТОП 5 лучших студентов
		private void StudentsTopFive()
		{
			// лучшие студенты
			List<SumScore> scoreSumTop5 = db.Scores
				.GroupBy(s => s.StudentName)
				.Select(scoresByStudent => new SumScore
				{
					StName = scoresByStudent.Key,
					Summ = scoresByStudent.Sum(s => s.Score)
				})
				.OrderByDescending(s => s.Summ)
				.Take(5)
				.ToList();

			ViewBag.TopFive = scoreSumTop5;

			// Худшие студенты
			List<SumScore> scoreSumBottom5 = db.Scores
				.GroupBy(s => s.StudentName)
				.Select(scoresByStudent => new SumScore
				{
					StName = scoresByStudent.Key,
					Summ = scoresByStudent.Sum(s => s.Score)
				})
				.OrderBy(s => s.Summ)
				.Take(5)
				.ToList();

			ViewBag.BottomFive = scoreSumBottom5;
		}

		public ActionResult StudentsTop()
		{
			StudentsTopFive();
			return View();
		}

		// подсчет баллов ТОП 5 худших студентов
		private void StudentsBottomFive()
		{
			List<SumScore> scoreSum = db.Scores
				.GroupBy(s => s.StudentName)
				.Select(scoresByStudent => new SumScore
				{
					StName = scoresByStudent.Key,
					Summ = scoresByStudent.Sum(s => s.Score)
				})
				.OrderBy(s => s.Summ)
				.Take(5)
				.ToList();

			ViewBag.BottomFive = scoreSum;
		}

		// вывод баллов в представление
		public ActionResult ViewSumScore()
		{
			StudentsBySumOfScore();
			return View();
		}

		// отображение всех студентов
		private void ViewStudents()
		{
			var allStudents = db.Students.ToList<Student>();
			ViewBag.Students = allStudents;
		}

		// отображение всех дисциплин
		private void ViewDisciplines()
		{
			var allDisciplines = db.Disciplines.ToList<Discipline>();
			ViewBag.Discipline = allDisciplines;
		}

		// отображение всех отметок
		private void ViewScores()
		{
			var allScores = db.Scores.ToList<Scores>();
			ViewBag.Scores = allScores;
		}
		
		[HttpGet]
		public ActionResult AddScore()
		{
			ViewStudents();
			ViewDisciplines();
			ViewScores();	
			return View();
		}

		[HttpPost]
		public ActionResult AddScore(Scores newScore)
		{
			newScore.ScoreDate = DateTime.Now;
			db.Scores.Add(newScore);
			db.SaveChanges();
			
			return RedirectToAction("Index", "Home");
	
		}

		[HttpGet]
		public ActionResult AddStudent()
		{
			ViewStudents();
			//ViewDisciplines();
			//ViewScores();

			return View();
		}

		[HttpPost]
		public ActionResult AddStudent(Student newStudent)
		{
			db.Students.Add(newStudent);
			db.SaveChanges();
			
			return RedirectToAction("Students", "Home");
		}

		[HttpGet]
		public ActionResult AddDiscipline()
		{
			//ViewStudents();
			ViewDisciplines();
			//ViewScores();

			return View();
		}

		[HttpPost]
		public ActionResult AddDiscipline(Discipline newDiscipline)
		{
			db.Disciplines.Add(newDiscipline);
			db.SaveChanges();
			
			return RedirectToAction("Disciplines", "Home");
		}

		// сохранение представлений в PDF через Rotativa с результатом	  

		public ActionResult PrintViewToPdf()
		{
			var printIndex = new ActionAsPdf("Index");
			return printIndex;
		}

		public ActionResult PrintSumScore()
		{
			var printScores = new ActionAsPdf("ViewSumScore");
			return printScores;
		}

	}
}
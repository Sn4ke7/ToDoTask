using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoTask.Models;

namespace ToDoTask.Controllers
{
	public class TaskController : Controller
	{
		private static IList<TaskModel> tasks = new List<TaskModel>()
		{
			new TaskModel(){ TaskId = 1, Name = "Sprawdzić Maile", Description = "Godzina 9:15", Done = false},
			new TaskModel(){ TaskId = 2, Name = "StandUp", Description = "Godzina 10:00", Done = false}
		};
		// GET: TaskController
		public ActionResult Index()
		{
			return View(tasks);
		}

		// GET: TaskController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: TaskController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: TaskController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: TaskController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: TaskController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: TaskController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: TaskController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}

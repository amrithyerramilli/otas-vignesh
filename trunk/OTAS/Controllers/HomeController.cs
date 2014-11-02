using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OTAS.Concrete;
using OTAS.Models;

namespace OTAS.Controllers
{
    public class HomeController : Controller
    {
        private EFDbContext db;
        public HomeController()
        {
            db = new EFDbContext();
        }
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginViewModel login)
        {
            
            var validator = db.Validator.Find(login.Usn);
            if(validator != null)
            {
                if ((validator.USN == login.Usn.ToUpper()) && (validator.PASSGEN == login.Password.ToUpper()))
                {
                    if (validator.FG == true)
                    {
                        return RedirectToAction("About", "Home");
                    }
                    Session.Add("USN", validator.USN);
                    if (validator.COUNTER != 0)
                    {
                        return RedirectToAction("Summary", "Home");
                    }
                    return RedirectToAction("Details", "Home");
                }
                else
                {
                    TempData["Error"] = "Invalid login credentials";
                    return View();

                }
            }
            else
            {
                TempData["Error"] = "Invalid user";
                return View();
            }
                

        }
        public ViewResult About()
        {
            ViewBag.USN = Session["USN"];
            return View();
        }
        public ActionResult Details()
        {
            var details = db.Students.Find(Session["USN"]);
            return View(details);
        }
        [HttpPost]
        public ActionResult Details(StudentModel model)
        {
            db.Entry(model).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            var valid = db.Validator.Find(Session["usn"]);
            valid.STUDENTDETAILS = true;
            return RedirectToAction("Summary", "Home");
        }
        public ActionResult Summary()
        {
            string usn = Session["USN"].ToString();
            var student = db.Students.Find(Session["usn"]);
            //var categorizedProducts = db.Teachers
            //                          .Join(db.Combination, p => p.TID, pc => pc.TID, (p, pc) => new { p, pc })
            //                          .Join(db.Subjects, ppc => ppc.pc.SubCode, c => c.SubCode, (ppc, c) => new { ppc, c })
            //                          .Where(db.c)
            //                          .Select(m => new
            //                           {
            //                                    Tid = m.ppc.p.TID, // or m.ppc.pc.ProdId
            //                                    Subcode = m.c.SubCode,
            //                                    Tname = m.ppc.p.TeacherName,
            //                                    Rid = m.ppc.pc.CombId,
            //                                    SubjectName = m.c.SubName
            //                            });
            var compulsary = db.Combination.Where(u => (u.Sem == student.Sem && u.Section == student.Section && u.Elective == false && u.DeptId == student.DeptId)).OrderBy(c => c.SubCode);
            var elect = db.Electives.Where(u => u.USN == usn).First();
            List<CombinationModel> data = new List<CombinationModel>();
            List<string> teachers = new List<string>();
            List<string> subjects = new List<string>();
            foreach (var r in compulsary)
            {
                teachers.Add((string)db.Teachers.Where(u => u.TID == r.TID).First().TeacherName);
                subjects.Add((string)db.Subjects.Where(u => u.SubCode == r.SubCode).First().SubName);
                data.Add(r);
            }
            if (elect.ELECTIVE1 != null)
            {
                var queueitem = db.Combination.Where(u => (u.Sem == student.Sem && u.Section == student.Section && u.Elective == true && u.SubCode == elect.ELECTIVE1));
                foreach (var q in queueitem)
                {
                    teachers.Add((string)db.Teachers.Where(u => u.TID == q.TID).First().TeacherName);
                    subjects.Add((string)db.Subjects.Where(u => u.SubCode == q.SubCode).First().SubName);
                    data.Add(q);
                }
                
            }
            if (elect.ELECTIVE2 != null)
            {
                var queueitem = db.Combination.Where(u => (u.Sem == student.Sem && u.Section == student.Section && u.Elective == true && u.SubCode == elect.ELECTIVE2));
                foreach (var q in queueitem)
                {
                    teachers.Add((string)db.Teachers.Where(u => u.TID == q.TID).First().TeacherName);
                    subjects.Add((string)db.Subjects.Where(u => u.SubCode == q.SubCode).First().SubName);
                    data.Add(q);
                }
            }
            if (elect.ELECTIVE3 != null)
            {
                var queueitem = db.Combination.Where(u => (u.Sem == student.Sem && u.Section == student.Section && u.Elective == true && u.SubCode == elect.ELECTIVE3));
                foreach (var q in queueitem)
                {
                    teachers.Add((string)db.Teachers.Where(u => u.TID == q.TID).First().TeacherName);
                    subjects.Add((string)db.Subjects.Where(u => u.SubCode == q.SubCode).First().SubName);
                    data.Add(q);
                }
            }
            if (elect.ELECTIVE4 != null)
            {
                var queueitem = db.Combination.Where(u => (u.Sem == student.Sem && u.Section == student.Section && u.Elective == true && u.SubCode == elect.ELECTIVE4));
                foreach (var q in queueitem)
                {
                    teachers.Add((string)db.Teachers.Where(u => u.TID == q.TID).First().TeacherName);
                    subjects.Add((string)db.Subjects.Where(u => u.SubCode == q.SubCode).First().SubName);
                    data.Add(q);
                }
            }
            ViewBag.data = data;
            ViewBag.subjects = subjects;
            ViewBag.teachers = teachers;
            var ds = data.Zip(subjects, (d,s) => new { Tid = d.TID, Subjectname = s, SubjectCode = d.SubCode, Rid = d.CombId} );
            var combination = ds.Zip(teachers, (d, t) => new { Tid = d.Tid, Subjectname = d.Subjectname, Subjectcode = d.SubjectCode, Rid = d.Rid, Teachername = t});
            List<Combination> combined = new List<Combination>();
            foreach (var r in combination)
            {
                Combination obj = new Combination();
                obj.Tid = r.Tid;
                obj.Teachername = r.Teachername;
                obj.Rid = r.Rid;
                obj.Subjectcode = r.Subjectcode;
                obj.Subjectname = r.Subjectname;
                combined.Add(obj);
            }
            ViewBag.combination = combined;
            Session["combination"] = combined;
            Session["total"] = combined.Count;
            return View();
        }
        [HttpGet]
        public ActionResult Rating()
        {
            var valid = db.Validator.Find(Session["usn"]);
            Combination newobj = new Combination();
            List<Combination> combi = new List<Combination>();
            combi = (List<Combination>)Session["combination"];
            int total = (int)Session["total"];
            int sum = valid.COUNTER + combi.Count;
            if(sum != total)
            {
                for (int i = 0; i < valid.COUNTER; i++ )
                {
                    combi.Remove(combi.First());
                }
            }
            newobj = combi.FirstOrDefault();
            if (newobj != null)
            {
                ViewBag.rate = newobj;
                return View();
            }
            else
            {
                valid.FG = true;
                db.SaveChanges();
                return RedirectToAction("About", "Home");
            }
        }
        [HttpPost]
        public ActionResult Evaluation(RatingsModel model)
        {
            if (ModelState.IsValid)
            {
                db.Ratings.Add(model);
                
                var update = db.Validator.Find(Session["usn"]);
                update.COUNTER += 1;
                var combi = (List<Combination>)Session["combination"];
                combi.Remove(combi.First());
                db.SaveChanges();
            }
            return RedirectToAction("Rating", "Home");
        }
        
	}
    public class Combination
    {
        public string Tid { get; set; }
        public string Subjectname { get; set; }
        public string Subjectcode { get; set; }
        public string Rid { get; set; }
        public string Teachername { get; set; }

    }

    
}
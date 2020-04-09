using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Reporting.WebForms;
using Studentmanagmentsystem.Models;

namespace Studentmanagmentsystem.Controllers
{
    public class StudentController : Controller
    {

        // GET: Student/Home
        public ActionResult Homepage()
        {
            return View();
        }

        // GET: Student
        public ActionResult Index()
        {
            using (DBModels dBModels = new DBModels())
            {
                return View(dBModels.StudentTBs.ToList());
            }
        }

        public ActionResult Reports(string ReportType)
        {
            LocalReport localreport = new LocalReport();
            DBModels dBModels = new DBModels();
            localreport.ReportPath = Server.MapPath("~/Reports/StudentReport.rdlc");

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "StudentDataSet1";
            reportDataSource.Value = dBModels.StudentTBs.ToList();
            localreport.DataSources.Add(reportDataSource);

            String reportType = ReportType;
            String mimeType;
            string encoding;
            String fileNameExtension;

            if(reportType == "PDF")
            {
                fileNameExtension = "pdf";
            }

            string[] strems;
            Warning[] warnings;
            byte[] renderdByte;

            renderdByte = localreport.Render(reportType, "", out mimeType, out encoding, out fileNameExtension, out strems, out warnings);
            Response.AddHeader("content-dispostion", "attachment:filename = student_report." + fileNameExtension);
            return File(renderdByte, fileNameExtension);

        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            using (DBModels dBModels = new DBModels())
            {
                return View(dBModels.StudentTBs.Where(x => x.sid == id).FirstOrDefault());
            }
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(StudentTB studentTB)
        {
            try
            {
                using (DBModels dBModels = new DBModels())
                {
                    dBModels.StudentTBs.Add(studentTB);
                    dBModels.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBModels dBModels = new DBModels())
            {
                return View(dBModels.StudentTBs.Where(x => x.sid == id).FirstOrDefault());
            }
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, StudentTB studentTB)
        {
            try
            {
                using(DBModels dBModels = new DBModels())
                {
                    dBModels.Entry(studentTB).State = System.Data.Entity.EntityState.Modified;
                    dBModels.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBModels dBModels = new DBModels())
            {
                return View(dBModels.StudentTBs.Where(x => x.sid == id).FirstOrDefault());
            }
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using(DBModels dBModels = new DBModels())
                {
                    StudentTB studentTB = dBModels.StudentTBs.Where(x => x.sid == id).FirstOrDefault();
                    dBModels.StudentTBs.Remove(studentTB);
                    dBModels.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using SachOnline.Models;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using Microsoft.Ajax.Utilities;

namespace SachOnline.Controllers
{
    public class FileAndMailController : Controller
    {
        // GET: FileAndMail
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SendMail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendMail(Mail model)
        {
            var mail = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("2024801030101@student.tdmu.edu.vn", "*****"),
                EnableSsl = true
            };
            var msg = new MailMessage();
            msg.From = new MailAddress(model.Form);
            msg.ReplyToList.Add(model.Form);
            msg.To.Add(new MailAddress(model.To));
            msg.Subject = model.Subject;
            msg.Body = model.Notes;

            var f = Request.Files["attachment"];
            var path = Path.Combine(Server.MapPath("~/UploadFile"), f.FileName);
            if (!System.IO.File.Exists(path))
            {
                f.SaveAs(path);
            }

            Attachment data = new Attachment(Server.MapPath("~/UploadFile/" + f.FileName), MediaTypeNames.Application.Octet);
            msg.Attachments.Add(data);

            mail.Send(msg);
            return View("SendMail");
        }
    }
}
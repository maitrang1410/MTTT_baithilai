using Microsoft.AspNetCore.Mvc;

namespace MTTT651_baithilai.controller;
public class MTTT651StudentController : Controller {
    public IActionResult Index() {
        return View();
    }
[HttpPost]
 public IActionResult Index(MTTT651Student st)
 {
        string StrOut= "Xin chao "+ st.StudentID + st.FullName+"-"+ st.NgaySinh;
        ViewBag.Message= StrOut;
        return View();
    }
    }

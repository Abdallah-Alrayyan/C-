using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string filePath = Server.MapPath("NewBooks.txt");

            string[] datafile = File.ReadAllLines(filePath);
            if (File.Exists(filePath))
            {
                foreach (string line in datafile)
                {
                    var data = line.Split(',');
                    string bookid = data[0];
                    string bookname = data[1];
                    string bookkind = data[2];
                    string booklevel = data[3];

                    booksTableBody.InnerHtml += $" <tr>  <td>{bookid}</td> <td>{bookname}</td> <td>{bookkind}</td> <td>{booklevel}</td>" +                                            
                                                $" </tr>";


                }
            }







        }



    }
}












































//// تحميل جميع الكتب من الملف وعرضها في الجدول
////private void LoadBooks()
////{
////    string filePath = Server.MapPath("NewBooks.txt");
////    string[] lines = File.ReadAllLines(filePath);
////    string tableContent = "";

////    foreach (var line in lines)
////    {
////        string[] data = line.Split(',');
////        //Console.WriteLine(data);

////        string bookId = data[0];
////        string bookName = data[1];
////        string bookKind = data[2];
////        string bookLevel = data[3];

////        // إضافة صف جديد للكتاب في الجدول مع زر تعديل
////        tableContent += $"<tr>" +
////                        $"<td>{bookId}</td>" +
////                        $"<td>{bookName}</td>" +
////                        $"<td>{bookKind}</td>" +
////                        $"<td>{bookLevel}</td>" +
////                        $"<td><a href='EditBook.aspx?bookId={bookId}' class='btn btn-warning'>Edit</a></td>" +
////                        $"</tr>";
////    }

////    // تعيين محتوى الجدول
////    booksTableBody.InnerHtml = tableContent;

////    // إذا كان هناك "bookId" في الـ QueryString، نقوم بتحميل بيانات الكتاب المحدد
////    if (Request.QueryString["bookId"] != null)
////    {
////        string bookId = Request.QueryString["bookId"];
////        LoadBookDetails(bookId);
////    }
////}

//// تحميل بيانات الكتاب المحدد بناءً على الـ ID
//private void LoadBookDetails(string bookId)
//{
//    string filePath = Server.MapPath("NewBooks.txt");
//    string[] lines = File.ReadAllLines(filePath);

//    foreach (var line in lines)
//    {
//        var data = line.Split(',');

//        if (data[0] == bookId)
//        {
//            // تعيين البيانات في النموذج
//            txtBookId.Text = data[0];
//            txtBookName.Text = data[1];
//            txtBookKind.Text = data[2];
//            txtBookLevel.Text = data[3];
//            break;
//        }
//    }
//}

//// تحديث بيانات الكتاب في الملف
//protected void UpdateBook_Click(object sender, EventArgs e)
//{
//    string bookId = txtBookId.Text;
//    string bookName = txtBookName.Text;
//    string bookKind = txtBookKind.Text;
//    string bookLevel = txtBookLevel.Text;

//    string filePath = Server.MapPath("NewBooks.txt");
//    string[] lines = File.ReadAllLines(filePath);
//    string updatedContent = "";

//    foreach (var line in lines)
//    {
//        var data = line.Split(',');

//        if (data[0] == bookId)
//        {
//            // تعديل البيانات في السطر المناسب
//            updatedContent += $"{bookId},{bookName},{bookKind},{bookLevel}\n";
//        }
//        else
//        {
//            updatedContent += line + "\n";
//        }
//    }

//    // حفظ التعديلات في الملف
//    File.WriteAllText(filePath, updatedContent);
//}

//protected void btnshow_Click(object sender, EventArgs e)
//{
//    Response.Redirect("showbook.aspx");
//}
//    }
//}
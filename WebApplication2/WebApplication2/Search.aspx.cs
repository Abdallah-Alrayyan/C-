using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            string filepath = Server.MapPath("NewBooks.txt");
            string[] fileData = File.ReadAllLines(filepath);
            foreach (string index in fileData)
            {
                string[] data = index.Split(',');
                string bookid = data[0];
                string bookname = data[1];
                string bookkind = data[2];
                string booklevel = data[3];

                if (bookid == search.Text)
                {
                    txtBookId.Text = bookid;
                    txtBookName.Text = bookname;
                    txtBookKind.Text = bookkind;
                    txtBookLevel.Text = booklevel;


                    //divBookId.Style["display"] = "block";
                    //divBookName.Style["display"] = "block";
                    //divBookKind.Style["display"] = "block";
                    //divBookLevel.Style["display"] = "block";


                }
            }

            btnEdit.Style["display"] = "block";
            btnSave.Style["display"] = "block";
        }



        protected void btnEdit_Click(object sender, EventArgs e)
        {
            txtBookId.Enabled = true;
            txtBookName.Enabled = true;
            txtBookKind.Enabled = true;
            txtBookLevel.Enabled = true;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string filepath = Server.MapPath("NewBooks.txt");
            string[] fileData = File.ReadAllLines(filepath);
            for (int i = 0; i < fileData.Length; i++)
            {
                string[] data = fileData[0].Split(',');
                string bookid = data[0];
                string bookname = data[1];
                string bookkind = data[2];
                string booklevel = data[3];

                if (bookid == search.Text)
                {
                    bookid = txtBookId.Text;
                    bookname = txtBookName.Text;
                    bookkind = txtBookKind.Text;
                    booklevel = txtBookLevel.Text;

                    fileData[i] = $"{bookid},{bookname},{bookkind},{booklevel}";

                  
                    File.WriteAllLines(filepath, fileData);
                    return;
                }


            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Xml;

namespace kpt.classes 
{
    public class Coursetest : System.Web.UI.Page
    {
        public void GetQuestions()
        {
            Sql pg = new Sql();
            DataTable dt = new DataTable();

            string sql = "select question_id, exam.question, category, img, answer_id, answer, " +
                "answers.question, correct from exam join answers on " +
                "exam.question_id = answers.question";

            Random rand = new Random(15);
            dt = pg.Select(sql);

            string path = Server.MapPath("xml/question.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNodeList qlist = doc.SelectNodes("test/question");

            

            foreach (DataRow row in dt.Rows)
            {
                string id = row[0].ToString();
                string question = row[1].ToString();
                string category = row[2].ToString();
                string img = row[3].ToString();
                string answer = row[4].ToString();
                string answerid = row[5].ToString();
                string correct = row[6].ToString();

                foreach (XmlNode node in qlist)
                {

                }
            }


            //XmlDocument docTwo = new XmlDocument();
            //docTwo.LoadXml("<Fråga>" + (string)Session["RandomQuestion"] + "<Svar>" + Session["0"] + "</Svar><Svar>" + Session["1"] + 
            //"</Svar><Svar>" + Session["2"] + "</Svar><Svar>" + Session["3"] + "</Svar><RättSvar>" + 
            //    xam.GetCorrectAnswerTemp((int)Session["rqID"]) + "</RättSvar><MarkeratSvar>"+selectedAnswer+"</MarkeratSvar></Fråga>");

            //XmlNode nodeTwo = doc.ImportNode(docTwo.FirstChild, true);
            //nodeOne.AppendChild(nodeTwo);

            //doc.Save(Server.MapPath("xml/prov.xml"));


            doc.Save(Server.MapPath("xml/test_" + Session.SessionID + "_.xml"));
            //ds.WriteXml(Server.MapPath("xml/questions.xml"));                   
        }
    }
}
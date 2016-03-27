using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Website_Editor
{
    public partial class Form1 : Form
    {
        public static List<EntryClass> data = new List<EntryClass>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    

        private void button3_Click(object sender, EventArgs e)
        {

            data.Clear();
            listBox1.Items.Clear();

            string projectsHtml_Main = System.IO.File.ReadAllText(@"D:\website1\portfolio-3-col.html");


            List<String> entry = new List<String>();

            using (StringReader reader = new StringReader(projectsHtml_Main))
            {
                Boolean started = false;
                string line = string.Empty;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        if (line.Contains("grid__brick col-md-4"))
                            started = true;

                        if (started)
                         entry.Add(line);

                        if (line.Contains("</div>") && started == true)
                            started = false;
                    }

                } while (line != null);
            }

            
            EntryClass dataclass = null;;
            foreach (String line in entry)
            {
                if (line != null)
                {
                    if (line.Contains("grid__brick col-md-4"))
                    { 

                        string[] splitTitle = line.Split(new string[] { "data-title=" }, StringSplitOptions.None);
                        String title = splitTitle[1].Substring(0, splitTitle[1].Length - 1);

                        string[] splitDate = line.Split(new string[] { "data-date-created=" }, StringSplitOptions.None);
                        string[] splitDate2 = splitDate[1].Split(new string[] { "data-title=" }, StringSplitOptions.None);
                        String date = splitDate2[0];

                        title = title.Replace("\"", "").Trim(); ;
                        date = date.Replace("\"", "").Trim(); ;

                        Console.WriteLine(title);
                        Console.WriteLine(date);

                        dataclass = new EntryClass();
                        dataclass.date = date;
                        dataclass.name = title;
                    }


                    if (line.Contains("a href=") && !line.Contains("h3") && !line.Contains("<p>"))
                    {
                        string[] splitHtmlIndel = line.Split(new string[] { "a href=" }, StringSplitOptions.None);
                        String indexHtml = splitHtmlIndel[1].Substring(0, splitHtmlIndel[1].Length - 1);

                        indexHtml = indexHtml.Replace("\"", "");
                        dataclass.srcLink = indexHtml;
                 
                        Console.WriteLine(indexHtml);
                    }

                    if (line.Contains("img-responsive"))
                    {
                        string[] splitImage = line.Split(new string[] { "src=" }, StringSplitOptions.None);
                        string[] splitImage2 = splitImage[1].Split(new string[] { "alt" }, StringSplitOptions.None);
                        String imageLink = splitImage2[0];
                        imageLink = imageLink.Replace("\"", "").Trim(); ;

                        dataclass.srcImage = imageLink;

                        Console.WriteLine(imageLink);
                    }

                        if (line.Contains("<p>"))
                    {
                        string[] spltDescription = line.Split(new string[] { "<p>" }, StringSplitOptions.None);
                        String description = spltDescription[1].Substring(0, spltDescription[1].Length - 4);

                        description = description.Replace("\"", "").Trim(); ;

                        dataclass.description = description;
                        Console.WriteLine(description);

                        Console.WriteLine("-----------");
                        data.Add(dataclass);

                    }

                }
            }

       
            foreach (EntryClass dataEntry in data)
            {
                listBox1.Items.Add(dataEntry.name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Edit project
            EntryClass selectedClass = data[listBox1.SelectedIndex]; //Get selected project
      
            Form2 editForm = new Form2();

            editForm.textbox_date.Text = selectedClass.date;
            editForm.textbox_name.Text = selectedClass.name;
            editForm.textbox_shortdesc.Text = selectedClass.description;
            editForm.textbox_thumbnail.Text = selectedClass.srcImage;
            editForm.textbox_srcLink.Text = selectedClass.srcLink;

            editForm.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //New Project

            String name = textbox_pName.Text;
            EntryClass entry = new EntryClass();
            entry.name = name;
            data.Add(entry);
            listBox1.Items.Add(entry.name);


            Form2 editForm = new Form2();

            editForm.textbox_date.Text = entry.date;
            editForm.textbox_name.Text = entry.name;
            editForm.textbox_shortdesc.Text = entry.description;
            editForm.textbox_thumbnail.Text = entry.srcImage;
            editForm.textbox_srcLink.Text = entry.srcLink;
            editForm.dataIndex = data.IndexOf(entry);
            editForm.Show();



        }

        private void button4_Click(object sender, EventArgs e)
        {
         
            foreach (EntryClass dataEntry in data)
            {
                int endIndex = 0;
                int currentIndex = 0;
                Boolean exists = false;
                String mainString = System.IO.File.ReadAllText(@"D:\website1\portfolio-3-col.html");
                String mainString_template = System.IO.File.ReadAllText(@"D:\website1\portfolio-3-col-template.txt");
                using (StringReader reader = new StringReader(mainString))
                {
                    Boolean started = false;
                    string line = string.Empty;
                    do
                    {
                        line = reader.ReadLine();
                        if (line != null)
                        {
                            if (line.Contains("grid__brick col-md-4"))
                                started = true;

                            if (started)
                            {
                                if (line.Contains(dataEntry.srcLink))
                                    exists = true;
                            }



                            if (line.Contains("</div>") && started == true)
                            {
                                started = false;
                                endIndex = currentIndex;
                                Console.WriteLine("end index " +endIndex);
                                
                            }
                        }
                        currentIndex++;

                    } while (line != null);
                }

                if (!exists)
                {
                    int currentIndex2 = 0;


                    List<String> entryFinal = new List<String>();
                    using (StringReader reader = new StringReader(mainString))
                    {
                        string line = string.Empty;
                        do
                        {
                            line = reader.ReadLine();
                            if (line != null)
                            {
                                if(currentIndex2==endIndex+2)
                                {
                                    line = line + mainString_template.Replace("NAME", dataEntry.name).
                                        Replace("SRCIMG", dataEntry.srcImage).Replace("DESCRIPTION", dataEntry.description)
                                        .Replace("DATE", dataEntry.date).Replace("SRCLINK", dataEntry.srcLink);
                                    Console.WriteLine(line);
                                }
                                entryFinal.Add(line);
                            }
                            currentIndex2++;
                        } while (line != null);
                    }


                    String finalText = "";
                    foreach (String line in entryFinal)
                    {
                        finalText += line + Environment.NewLine;
                    }

                    File.WriteAllText(@"D:\website1\portfolio-3-col.html", finalText);
                }

            }


        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public int dataIndex=0;

        private void Form2_Load(object sender, EventArgs e)
        {
            //Load fields

            String targetHtml = this.textbox_srcLink.Text;
            string projectsHtml_subProject = null;
            try
            {
                projectsHtml_subProject = System.IO.File.ReadAllText(@"D:\website1\" + targetHtml);
            }
            catch (Exception)
            {

            }

            if (projectsHtml_subProject != null)
            {
                List<String> entry = new List<String>();
                using (StringReader reader = new StringReader(projectsHtml_subProject))
                {
                    string line = string.Empty;
                    do
                    {
                        line = reader.ReadLine();
                        if (line != null)
                        {
                            entry.Add(line);
                        }

                    } while (line != null);
                }

                Boolean foundImage = false;
                Boolean etc_Started = false;
                foreach (String line in entry)
                {
                    if (line != null)
                    {
                        if (line.Contains("<!--TYPE-->"))
                        {
                            String type = line.Replace("<small>", "").Replace("</small>", "").Replace("<!--TYPE-->", "").Trim();
                            textbox_type.Text = type;
                        }

                        if (foundImage)
                        {
                            if (line.Contains("img-responsive"))
                            {
                                string[] splitImage = line.Split(new string[] { "src=" }, StringSplitOptions.None);
                                string[] splitImage2 = splitImage[1].Split(new string[] { "alt" }, StringSplitOptions.None);
                                String imageLink = splitImage2[0];
                                imageLink = imageLink.Replace("\"", "").Trim();

                                textbox_images.Text = textbox_images.Text + imageLink + Environment.NewLine;
                            }
                        }

                        if (line.Contains("<!--LONG_DESC-->"))
                        {
                            String longDesc = line.Replace("<!--LONG_DESC-->", "").Replace("<p>", "").Replace("</p>", "").Trim();
                            textbox_longdesc.Text = longDesc;
                        }

                        if (line.Contains("<!--END_ETC-->"))
                        {
                            etc_Started = false;
                        }

                        if (etc_Started)
                        {
                            textbox_etc.Text = textbox_etc.Text + line.Trim() + Environment.NewLine;
                        }

                        if (line.Contains("<!--IMAGES-->"))
                        {
                            foundImage = true;
                        }
                        if (line.Contains("<!--IMAGES_END-->"))
                        {
                            foundImage = false;
                        }
                        if (line.Contains("<!--START_ETC-->"))
                        {
                            etc_Started = true;
                        }
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SAVE, shittiest code 2016
            //I dont even know so dont ask
            string projectsHtml_subProject_template = System.IO.File.ReadAllText(@"D:\website1\portfolio-item-template.html");

            projectsHtml_subProject_template = projectsHtml_subProject_template.Replace("<!--NAME_FIELD-->", textbox_name.Text).
                                                                                Replace("<!--TYPE_FIELD-->", textbox_type.Text).
                                                                                Replace("<!--LONG_DESC_FIELD-->", textbox_longdesc.Text).
                                                                                Replace("<!--ETC_FIELD-->", textbox_etc.Text);

            bool foundImage = false;
            bool foundImage2 = false;
            int imageIndex = 0;
            int nullsReplaced = 0;
           
            String[] images = textbox_images.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int totalImages = images.Length;


            List<String> entry = new List<String>();
            using (StringReader reader = new StringReader(projectsHtml_subProject_template))
            {
                string line = string.Empty;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {

                        if (foundImage && imageIndex < totalImages)
                        {
                            line = line.Replace("<!--", "").Replace("-->", "");
                            imageIndex++;
                        }

                        if (line.Contains("<!--IMAGES_INDICATOR-->"))
                        {
                            foundImage = true;
                        }
                        if (line.Contains("<!--IMAGES_INDICATOR_END-->"))
                        {
                            foundImage = false;
                        }


                        for (int i = 0; i < totalImages; i++)
                        {
                            if (line.Contains("<!--IMAGE_" +  i + "-->"))
                            {
                                line = line.Replace("<!--IMAGE_" + i + "-->", images[i]).Replace("null", "img");
                            }
                        }


                        if (foundImage2)
                        {
                            if (line.Contains("null")&&nullsReplaced<totalImages-1)
                            {
                                line = line.Replace("null", "item");
                                nullsReplaced++;
                            }
                        }

                        if (line.Contains("<!--IMAGES-->"))
                        {
                            foundImage2 = true;
                        }
                        if (line.Contains("<!--IMAGES_END-->"))
                        {
                            foundImage2 = false;
                        }

                        entry.Add(line);
                    }

                } while (line != null);
            }

            String finalText = "";
            foreach(String line in entry)
            {
                finalText += line + Environment.NewLine;
            }


            File.WriteAllText(@"D:\website1\" + textbox_srcLink.Text, finalText);

            Form1.data[dataIndex].srcLink = textbox_srcLink.Text;
            Form1.data[dataIndex].srcImage = textbox_thumbnail.Text;
            Form1.data[dataIndex].description = textbox_shortdesc.Text;
            Form1.data[dataIndex].name = textbox_name.Text;
            Form1.data[dataIndex].date = textbox_date.Text;
            
        }
    }
}

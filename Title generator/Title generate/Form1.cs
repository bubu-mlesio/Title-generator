using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Title_generate
{
    public partial class Form1 : Form
    {
        string[] allLines;
        List<string> title = new List<string>();
        List<string> bug_words = new List<string>();
        List<string> models = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            read_models(models_name.Text);
            //check main title
            check_string(title_name.Text);
            
            string tmp = title_name.Text;
            //create titles with models
            for (int i =0; i<models.Count(); i++)
            {

                if (tmp.Length < 50)
                {
                    tmp += " " + models[i];
                }
                else if (tmp.Length == 50)
                {
                    title.Add(tmp);
                    tmp = title_name.Text + " " + models[i];
                }
                else if (tmp.Length > 50)
                {
                    int num = tmp.Length - (models[i - 1].Length + 1);
                    title.Add(tmp.Substring(0, num));
                    tmp = title_name.Text;
                    i = i - 2;
                }
                if (i == models.Count()-1)
                {
                    if (models[i] != "\n")
                        {
                            title.Add(tmp);
                            tmp = null;
                        }
                }
                Thread.Sleep(10);
            }
            //save titles
            save("title.txt", false);
            //clean collections
            title.Clear();
            bug_words.Clear();
            models.Clear();
        }
        //check main title
        private void check_string (string name)
        {
            if(name.Length >= 50)
            {
                MessageBox.Show("Tytuł jest za długi", "ERROR 404", MessageBoxButtons.OK);
                this.Close();
            }
            string ttt;
            for (int i = 0; i < allLines.Count(); i++)
            {
                ttt = name + " " + allLines[i];
                if (ttt.Length > 50)
                {
                    bug_words.Add(allLines[i] + "\n");
                    allLines[i] = "";
                }
                    
            }
            foreach(string model in allLines)
            {
                if(model != "")
                {
                    models.Add(model);
                }
            }
            if (bug_words.Count() > 0)
            {
                //save to file incorrect models
                save("models_too_long.txt", true);
                MessageBox.Show("Lista za długich modeli zapisuję do pliku models_too_long.txt", "404", MessageBoxButtons.OK);
            }


        }
        private void read_models(string models)
        {
            //load from text box
            if (fromFile.CheckState.ToString() == "Unchecked")
            {
                if (models.Length > 0)
                {
                    allLines = models.Split('\n');
                    for (int i = 0; i < allLines.Count(); i++)
                    {
                        if (i != allLines.Count() - 1)
                            allLines[i] = allLines[i].Substring(0, allLines[i].Length - 1);
                    }
                }
                else
                    MessageBox.Show("Ilość modeli jest zbyt mała", "404 ERROR", MessageBoxButtons.OK);

            }
        //load from file
            else
            {
                if (File.Exists(file_name.Text + ".txt"))
                    allLines = File.ReadAllLines(file_name.Text + ".txt", Encoding.UTF8);
                else
                    MessageBox.Show("Brak wskazanego pliku " +file_name.Text + ".txt", "404 ERROR", MessageBoxButtons.OK);
            }
         }
        //save to file
        private void save(string file_name, bool models_name)
        {

            try
            {
                StreamWriter sw = new StreamWriter(file_name, true);
                if (models_name == false)
                {
                    foreach (string tekst in title)
                        sw.WriteLine(tekst);
                }
                else
                {
                    foreach(string tekst in bug_words)
                        sw.WriteLine(tekst);
                }
                sw.WriteLine(" ");
                sw.Close();
                MessageBox.Show("Zapis pomyślny!", "Success!", MessageBoxButtons.OK);
            }catch (Exception e)
            {
                MessageBox.Show("Wystąpił błąd: " + e.ToString(), "404", MessageBoxButtons.OK);
            }
        }

        private void fromFile_CheckedChanged(object sender, EventArgs e)
        {
            if (file_name.Visible == true)
            {
                file_name.Visible = false;
            }
            else
                file_name.Visible = true;
        }
    }
}

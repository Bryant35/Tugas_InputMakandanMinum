using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makanan_Minuman
{
    public partial class Form1 : Form
    {
        int countmakan = 0;
        int countminum = 0;
        public Form1()
        {
            InitializeComponent();
            textBoxItem.Focus();
            makanan[0] = "Mie Instan";
            listBoxInput.Items.Add(makanan[0]);
            makanan[1] = "Telor";
            listBoxInput.Items.Add(makanan[1]);
            minuman[0] = "Susu Sapi";
            listBoxInput.Items.Add(minuman[0]);
            minuman[1] = "Kopi";
            listBoxInput.Items.Add(minuman[1]);
            makanan[2] = "Roti";
            listBoxInput.Items.Add(makanan[2]);
            makanan[3] = "Keju";
            listBoxInput.Items.Add(makanan[3]);
            makanan[4] = "Daging Giling";
            listBoxInput.Items.Add(makanan[4]);
            minuman[2] = "Teh";
            listBoxInput.Items.Add(minuman[2]);
            minuman[3] = "Bir";
            listBoxInput.Items.Add(minuman[3]);
            countmakan = countmakan + 5;
            countminum = countminum + 4;
            //for (int i = 0; i < 5; i++)
            //{
            //    listBoxInput.Items.Add(makanan[i]);
            //    if (i != 4)
            //    {
            //        listBoxInput.Items.Add(minuman[i]);
            //    }
            //}
        }
        
        private void textBoxItem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonMakanan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMinuman_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        string[] makanan = new string[30];
        string[] minuman = new string[30];
        
        private void buttonInput_Click(object sender, EventArgs e)
        {
            
            if (radioButtonMakanan.Checked == true)
            {
                makanan[countmakan] = textBoxItem.Text;
                listBoxInput.Items.Add(makanan[countmakan]);
                countmakan++;
            }
            else if(radioButtonMinuman.Checked == true)
            {
                minuman[countminum] = textBoxItem.Text;
                listBoxInput.Items.Add(minuman[countminum]);
                countminum++;
            }
        }

        private void listBoxInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxInput.SelectionMode = SelectionMode.MultiExtended;
            
        }

        private void buttonSalin_Click(object sender, EventArgs e)
        {
            string[] list = listBoxInput.Items.OfType<string>().ToArray();
            int listcount = listBoxInput.SelectedItems.Count;
            //for (int i = 0; i < listcount; i++)
            //{
            //    string result = string.Join(",", list[listBoxInput.SelectedIndex]);
            //    listBoxList.Items.Add(result);
            //}
            for (int i = 0; i < listcount; i++)
            {
                if (listBoxInput.SelectedIndex > -1 && listBoxInput.SelectedItem == makanan[i])
                {
                    //string result = string.Join(",", list[listBoxInput.SelectedIndex]);
                    listBoxList.Items.Add(listBoxInput.SelectedItem);
                }
                else if (listBoxInput.SelectedIndex > -1 && listBoxInput.SelectedItem == minuman[i])
                {
                    string result = string.Join(",", list[listBoxInput.SelectedIndex]);
                    listBoxList.Items.Add(result);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int recountfood = 0;
            int recountdrink = 0;
            for (int i = 0; i < countmakan + countminum; i++)
            {
                if (listBoxInput.SelectedIndex > -1 && listBoxInput.SelectedItem == makanan[i])
                {
                    listBoxInput.Items.RemoveAt(listBoxInput.SelectedIndex);
                    recountfood++;
                }
                else if(listBoxInput.SelectedIndex > -1 && listBoxInput.SelectedItem == minuman[i])
                {
                    listBoxInput.Items.RemoveAt(listBoxInput.SelectedIndex);
                    recountdrink++;
                }
            }
            countmakan = countmakan - recountfood;
            countminum = countminum - recountdrink;
        }

        private void checkBoxMakanan_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxMakanan.Checked == true)
            {
                for (int i = 0; i < countmakan; i++)
                {
                    if (makanan[i] == "")
                    {

                    }
                    else
                    {
                        listBoxInput.SetSelected(listBoxInput.FindString(makanan[i]), true);
                    }
                }
            }
            else if(checkBoxMakanan.Checked == false)
            {
                listBoxInput.ClearSelected();
                if (checkBoxMinuman.Checked == true)
                {
                    for (int i = 0; i < countminum; i++)
                    {
                        if (minuman[i] == "")
                        {

                        }
                        else
                        {
                            listBoxInput.SetSelected(listBoxInput.FindString(minuman[i]), true);
                        }
                    }
                }
            }
        }

        private void checkBoxMinuman_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMinuman.Checked == true)
            {
                for (int i = 0; i < countminum; i++)
                {
                    if (minuman[i] == "")
                    {

                    }
                    else if(minuman[i] != "")
                    {
                        listBoxInput.SetSelected(listBoxInput.FindString(minuman[i]), true);
                    }
                }
            }
            else if(checkBoxMinuman.Checked == false)
            {
                listBoxInput.ClearSelected();
                if(checkBoxMakanan.Checked == true)
                {
                    for (int i = 0; i < countmakan; i++)
                    {
                        if (makanan[i] == "")
                        {

                        }
                        else
                        {
                            listBoxInput.SetSelected(listBoxInput.FindString(makanan[i]), true);
                        }
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excersise3
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void delete_button_Click_1(object sender, EventArgs e)
        {
            if (delete_rtdbutton.Checked == true) 
            {
                string x = delete_textBox.Text; 
                x = x.ToUpper().Trim();
                int m = 0;
                int l = AddVocabulary.hash.HashFuntion(x);
                int demo = AddVocabulary.hash.HashAgain(l);
                while (true)
                {
                    if (AddVocabulary.dic[demo] != null && String.Compare(AddVocabulary.dic[demo].Word.Word1, x) == 0)
                    {
                        AddVocabulary.dic[demo] = null;
                        break;
                    }
                    else
                    {
                        demo = AddVocabulary.hash.HashAgain(demo);
                        m++;
                        if (m > 250)
                        {
                            show_textbox.Text += "KHÔNG CÓ TỪ NÀY TRONG TỪ ĐIỂN ! ";
                            break;
                        }
                    }
                }
            }
        }
              
        private void watch_button_Click(object sender, EventArgs e)
        {
            show_textbox.Text += "\n\t\t\t======ENGLISH DICTIONARY======\n";
            for (int i = 0; i < 250; i++)
            {
                if (AddVocabulary.dic[i] != null)
                {
                    show_textbox.Text += "\n==================== Number Of Pages " + i + " =====================";
                    DictNode p = AddVocabulary.dic[i];
                    while (p != null)
                    {
                        show_textbox.Text += "\nEngLish:" + p.Word.Word1;
                        show_textbox.Text += "\nIpa: " + p.Word.Ipa;
                        show_textbox.Text += "\nType: " + p.Word.Type;
                        show_textbox.Text += "\nVietnamese Meaning:" + p.Word.Mean;
                        if (String.Compare(p.Word.Synonyms,"")==0)
                        {
                            break;
                        }
                        else 
                        { 
                            show_textbox.Text += "\nSynonyms:" + p.Word.Synonyms;
                        }
                        p = null;
                    }
                }
            }
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            if (add_word_rdtbutton.Checked == true)
            {
                string[]ENGLISH_new =new string[] {english_textbox.Text};
                string[] TYPE_new = new string[] {type_textBox.Text };
                string[] MEAN_new = new string[] {mean_textbox.Text };
                string[] IPA_new = new string[] {ipa_textbox.Text };
                string[] SYNONYMS_new = new string[] {synonyms_textbox.Text};
                for (int i = 0; i < ENGLISH_new.Length; i++)
                {
                    AddVocabulary.w = new Word(ENGLISH_new[i].ToUpper().Trim(), IPA_new[i].ToUpper(), TYPE_new[i].ToUpper(), MEAN_new[i].ToUpper(), SYNONYMS_new[i].ToUpper().Trim());
                    AddVocabulary.hash.AddVocabulary(AddVocabulary.dic, AddVocabulary.w);
                }
            }
        }
        private void update_button_Click(object sender, EventArgs e)
        {
            if(update_rdtbutton.Checked==true)
            {
            string x = English_mean_texbox.Text;
            x = x.Trim().ToUpper();
            string y = Mean_update_texbox.Text;
            y = y.Trim().ToUpper();
            int l = AddVocabulary.hash.HashFuntion(x);
            int k = AddVocabulary.hash.HashAgain(l);
            int t = 0;
                while (true)
                {
                    if (AddVocabulary.dic[k] != null && String.Compare(AddVocabulary.dic[k].Word.Word1, x) == 0)
                    {
                        AddVocabulary.dic[k].Word.Mean = y;
                        break;
                    }
                    else
                    {
                        k = AddVocabulary.hash.HashAgain(k);
                        t++;
                        if (t > 250)
                        {
                            show_textbox.Text += "KHÔNG CÓ TỪ NÀY TRONG TỪ ĐIỂN ! ";
                            break;
                        }
                    }
                }
            }
        }

        public void Clear()
        {
            show_textbox.Clear();
            delete_textBox.Clear();
            Mean_update_texbox.Clear();
            English_mean_texbox.Clear();
            synonyms_textbox.Clear();
            ipa_textbox.Clear();
            mean_textbox.Clear();
            english_textbox.Clear();
            type_textBox.Clear();
        }
        private void Remove_people_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void ExitApp_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void delete_button_Click(object sender, EventArgs e)
        {

        }

        private void delete_rtdbutton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Admin_Load(object sender, EventArgs e)
        {

        }
        private void English_label_Click(object sender, EventArgs e)
        {

        }

        private void english_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void type_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mean_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ipa_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void synonyms_textbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void add_word_rdtbutton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void update_rdtbutton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void show_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

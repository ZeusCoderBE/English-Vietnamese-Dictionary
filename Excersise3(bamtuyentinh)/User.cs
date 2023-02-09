using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Excersise3
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();

        }
 
         private void Search_button_Click(object sender, EventArgs e)
        {
            if (rdt_Searchbutton.Checked == true)
            {
                string x = Search_textbox.Text;
                x = x.ToUpper().Trim();
                int m = 0;
                int l = AddVocabulary.hash.HashFuntion(x);
                int demo = AddVocabulary.hash.HashAgain(l);
                while (true)
                {
                    if (AddVocabulary.dic[demo] != null && String.Compare(AddVocabulary.dic[demo].Word.Word1, x) == 0)
                    {
                        show_textbox.Text += "\n";
                        show_textbox.Text += "\nTừ Tiếng Anh: " + AddVocabulary.dic[demo].Word.Word1;
                        show_textbox.Text += "\nPhiên Âm:" + AddVocabulary.dic[demo].Word.Ipa;
                        show_textbox.Text += "\nLoại Từ: " + AddVocabulary.dic[demo].Word.Type;
                        show_textbox.Text += "\nNghĩa Tiếng Việt: " + AddVocabulary.dic[demo].Word.Mean;
                        if (String.Compare(AddVocabulary.dic[demo].Word.Synonyms,"")==0)
                        {
                            break;
                        }
                        else
                        {
                            show_textbox.Text += "\nTừ Đồng Nghĩa: " + AddVocabulary.dic[demo].Word.Synonyms;
                            break;
                        }
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
                    show_textbox.Text += "\n==================== Number Of Pages "+i+" =====================";
                    DictNode p= AddVocabulary.dic[i];
                    while (p != null)
                    {
                        show_textbox.Text += "\nEngLish:" + p.Word.Word1;
                        show_textbox.Text += "\nIpa: " + p.Word.Ipa;
                        show_textbox.Text += "\nType: " + p.Word.Type;
                        show_textbox.Text += "\nVietnamese Meaning:" + p.Word.Mean;
                        if (String.Compare(p.Word.Synonyms, "")==0)
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
        public void Clear()
        {
            show_textbox.Clear();
            Search_textbox.Clear();
        }
        private void Remove_people_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Search_Click(object sender, EventArgs e)
        {

        }
        private void rdt_Searchbutton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdt_addbutton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Google_Load(object sender, EventArgs e)
        {

        }
        private void rdt_seacrh_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void show_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace Excersise3
{
    public class  HashTable<t>
    {
        #region Hàm Khởi Tạo
        public void InitHash(DictNode[] head)
        {
            for (int i = 0; i < 250; i++)
            {
                head[i] = null;
            }
        }
        #endregion
        #region  Băm theo kết nối trực tiếp
        public int HashFuntion(string en)
        {
            int h = 0;
            for (int i = 0; i < en.Length; i++)
            {
                h += Convert.ToInt32((en[i]))*(i+1);
            }
            return h % 250;
        }
        #endregion
        #region  Hàm tạo từ 
        public DictNode CreateNode(Word w)
        {
            DictNode word = new DictNode();
            if(word==null)
            {
                Console.WriteLine("Không đủ bộ nhớ ! ");
            }
            word.Word = w;
            word.Next = null;
            return word;
        }
#endregion
        #region Hàm Băm Lại
        public int HashAgain(int index)
        {
            int demo= (index + 1) % 250;
            return demo;
        }
        #endregion
        #region  Hàm Thêm cho phương pháp băm tuyến tính
        public void AddVocabulary(DictNode[] head, Word w)
        {
            int k = HashFuntion(w.Word1);
            DictNode p = CreateNode(w);
            if (head[k] == null)
            {
                head[k] = p;
            }
            else
            {
                int  demo = HashAgain(k);
               jump:
                    if (head[demo] == null)
                    {
                        head[demo] = p;
                    }
                    else
                    {
                        demo = HashAgain(demo);
                      goto jump;
                    }
             }     
        }
        #endregion
    }
}



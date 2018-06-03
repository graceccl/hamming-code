using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hamming1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int errorbit;
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            inputInfo();//encode
            

        }
        public void inputHam()
        {
            labelInfoOut.Text="Information bits : ";
            labelCH.Text = "Correct Hamming code : ";
            labelWrongbit.Text = "Wrong bit : ";
            string ham = textBoxHam.Text;
            labelCH.Text += getCH(ham);
            if(errorbit==0)
                labelWrongbit.Text += "no";
            else
                labelWrongbit.Text += errorbit;
            labelInfoOut.Text += getInfo(ham);
        }
        public void inputInfo()
        {
            labelSet.Text = "Set Hamming code : ";
            string info = textBoxInfo.Text;
            int n = info.Length;
            int k = 0;
            for (int ki = 0; ki >= 0; ki++)
            {
                if (Math.Pow(2, ki) >= n + ki + 1)
                {
                    k = ki;
                    break;
                }
                else
                    continue;
            }

            for (int i = 0; i < k; i++)
            {
                int index = Convert.ToInt32(Math.Pow(2, i));
                info = info.Insert(n - index + 1 + i, Convert.ToString(2 + i));
            }
            labelSet.Text += getHam(info, n, k);
        }
        public string getInfo(string ham)
        {
            int h = ham.Length;
            int k = Convert.ToString(h, 2).Length;
            string[] hamarr = new string[h];
            string[] infoarr = new string[h - k];
            string info="";
            for(int i=0;i<h;i++)
            {
                hamarr[h-i-1] = getCH(ham).Substring(i, 1);
            }
            int cnt = 0;
            int jtemp = 0;
            for (int i = 0; i < h - k; i++)
            {
                while(jtemp<=k)
                {
                    if (cnt != Convert.ToInt32(Math.Pow(2, jtemp)) - 1)
                    {
                        infoarr[i] = hamarr[cnt];
                        cnt++;
                        break;
                    }
                    else
                        infoarr[i] = hamarr[cnt + 1];
                    cnt++;
                    jtemp++;
                }
            }
            for (int i = 0; i < h - k; i++)
            {
                info += infoarr[h - k - i - 1];
            }

            return info;
        }
        public string getCH(string ham)
        {
            int h = ham.Length;
            string temp = "";
            for (int i = 0; i < h; i++)
            {
                temp += ham.Substring(h - i - 1, 1);
            }
            int k=Convert.ToString(h, 2).Length;
            string[] arr = new string[h];
            for (int i = 0; i < h; i++)
            {
                if (temp.Substring(i, 1) == "0")
                    arr[i] = "0";
                else
                    arr[i] = Convert.ToString(i + 1, 2);//十進位轉二進位
                if (arr[i].Length < k)
                {
                    int addzero = k - arr[i].Length;
                    for (int j = 0; j < addzero; j++)
                    {
                        arr[i] = arr[i].Insert(0, "0");
                    }
                }
            }
            int[] num = new int[k];
            int[] bit = new int[k];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    num[i] += Convert.ToInt32(arr[j].Substring(i, 1));
                }
                if (radioButtonEvenDe.Checked)
                {
                    if (num[i] % 2 == 0)
                        bit[i] = 0;
                    else
                        bit[i] = 1;
                }
                else if (radioButtonOddDe.Checked)
                {
                    if (num[i] % 2 == 1)
                        bit[i] = 0;
                    else
                        bit[i] = 1;
                }
                else
                {
                    MessageBox.Show("Please select parity.");
                }
            }
            string bits = "";
            for (int i = 0; i < k; i++)
            {
                bits += bit[i];
            }
            errorbit=Convert.ToInt32(bits, 2);//二進位轉十進位
            string[] arrh=new string[h];
            for(int i=0;i<h;i++)
            {
                if (i == h - errorbit )
                {
                    if(ham.Substring(i, 1)=="1")
                        arrh[i] = "0";
                    else
                        arrh[i] = "1";
                }
                else
                    arrh[i] = ham.Substring(i, 1);
            }
            string ch="";
            for(int i=0;i<h;i++)
            {
                ch+=arrh[i];
            }
            return ch;
        }
        public string getHam(string info, int n, int k)
        {
            int newlength = n + k;
            string[] arr = new string[newlength];
            string temp="";
            for (int i = 0; i < newlength; i++)
            {
                temp += info.Substring(newlength-i-1, 1);
            }
            for (int i = 0; i < newlength; i++)
            {
                if (temp.Substring(i, 1) == "0")
                    arr[i] = "0";
                else
                    arr[i]=Convert.ToString(i+1, 2);//十進位轉二進位
                if (arr[i].Length < k)
                {
                    int addzero=k-arr[i].Length;
                    for(int j=0;j<addzero;j++)
                    {
                        arr[i] = arr[i].Insert(0, "0");
                    }
                }
            }
            int[] num = new int[k];
            int[] bit = new int[k];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < newlength; j++)
                {
                    num[i] += Convert.ToInt32(arr[j].Substring(i, 1));
                }
                if (radioButtonEvenEn.Checked)
                {
                    if (num[i] % 2 == 0)
                        bit[i] = 1;
                    else
                        bit[i] = 0;
                }
                else if (radioButtonOddEn.Checked)
                {
                    if (num[i] % 2 == 0)
                        bit[i] = 0;
                    else
                        bit[i] = 1;
                }
                else
                {
                    MessageBox.Show("Please select parity.");
                }
            }
            for (int i = 0; i < k; i++)
            {
                string oldval=Convert.ToString(2+i);
                string newval=Convert.ToString(bit[k-i-1]);
                info=info.Replace(oldval,newval);
            } 
            return info;
        }

        private void buttonDe_Click(object sender, EventArgs e)
        {
            inputHam();//decode
        }
        
    }
}

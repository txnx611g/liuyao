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

namespace zml.liuyao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
            textBox4.Text =  "明天涨跌走势如何";
            label8.Text= DateTime.Now.ToString();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int upRemain = Convert.ToInt32(textBox1.Text) % 8;

            if (upRemain == 0)
            {
                upRemain = 8;
            }

            label4.Text = upRemain.ToString();

            upRemain = Convert.ToInt32(textBox2.Text) % 8;

            if (upRemain == 0)
            {
                upRemain = 8;
            }

            label5.Text = upRemain.ToString();


            upRemain = Convert.ToInt32(textBox3.Text) % 6;

            if (upRemain == 0)
            {
                upRemain = 6;
            }

            label6.Text = upRemain.ToString();

            if (label5.Text == "1")
            {
                switch (label4.Text )
                {
                    case "1":
                        label7.Text = "乾为天190";
                        break;
                    case "2":
                        label7.Text = "天泽履224";
                        break;
                    case "3":
                        label7.Text = "天火同人235";
                        break;
                    case "4":
                        label7.Text = "天雷无妄275";
                        break;
                    case "5":
                        label7.Text = "天风姤343";
                        break;
                    case "6":
                        label7.Text = "天水讼209";
                        break;
                    case "7":
                        label7.Text = "天山遁306";
                        break;
                    case "8":
                        label7.Text = "天地否231";
                        break;
                    default:
                        break;
                }

            }
           else if (label5.Text == "2")
            {
                switch (label4.Text)
                {
                    case "1":
                        label7.Text = "泽天夬224";
                        break;
                    case "2":
                        label7.Text = "兑为泽389";
                        break;
                    case "3":
                        label7.Text = "泽火革359";
                        break;
                    case "4":
                        label7.Text = "泽雷随249";
                        break;
                    case "5":
                        label7.Text = "泽风大过296";
                        break;
                    case "6":
                        label7.Text = "泽水困352";
                        break;
                    case "7":
                        label7.Text = "泽山咸299";
                        break;
                    case "8":
                        label7.Text = "泽地萃346";
                        break;
                    default:
                        break;
                }

            }
           else if (label5.Text == "3")
            {
                switch (label4.Text)
                {
                    case "1":
                        label7.Text = "火天大有238";
                        break;
                    case "2":
                        label7.Text = "火泽睽359";
                        break;
                    case "3":
                        label7.Text = "离为火295";
                        break;
                    case "4":
                        label7.Text = "火雷噬嗑261";
                        break;
                    case "5":
                        label7.Text = "火风鼎362";
                        break;
                    case "6":
                        label7.Text = " 火水未济412";
                        break;
                    case "7":
                        label7.Text = "火山旅383";
                        break;
                    case "8":
                        label7.Text = "火地晋312";
                        break;
                    default:
                        break;
                }

            }
           else if (label5.Text == "4")
            {
                switch (label4.Text)
                {
                    case "1":
                        label7.Text = "雷天大壮296";
                        break;
                    case "2":
                        label7.Text = "雷泽归妹375";
                        break;
                    case "3":
                        label7.Text = "雷火丰379";
                        break;
                    case "4":
                        label7.Text = "震为雷365";
                        break;
                    case "5":
                        label7.Text = "雷风恒302";
                        break;
                    case "6":
                        label7.Text = "雷水解329";
                        break;
                    case "7":
                        label7.Text = "雷山大过404";
                        break;
                    case "8":
                        label7.Text = "雷地豫246";
                        break;
                    default:
                        break;
                }

            }
           else if (label5.Text == "5")
            {
                switch (label4.Text)
                {
                    case "1":
                        label7.Text = "风天小畜221";
                        break;
                    case "2":
                        label7.Text = "风泽中孚400";
                        break;
                    case "3":
                        label7.Text = "风火家人319";
                        break;
                    case "4":
                        label7.Text = "风雷益337";
                        break;
                    case "5":
                        label7.Text = "巽为风386";
                        break;
                    case "6":
                        label7.Text = "风水涣395";
                        break;
                    case "7":
                        label7.Text = "风山渐372";
                        break;
                    case "8":
                        label7.Text = "风地观258";
                        break;
                    default:
                        break;
                }

            }
           else if (label5.Text == "6")
            {
                switch (label4.Text)
                {
                    case "1":
                        label7.Text = "水天需205";
                        break;
                    case "2":
                        label7.Text = "水泽节397";
                        break;
                    case "3":
                        label7.Text = "水火未济408";
                        break;
                    case "4":
                        label7.Text = "水雷屯198";
                        break;
                    case "5":
                        label7.Text = "水风井355";
                        break;
                    case "6":
                        label7.Text = "坎为水291";
                        break;
                    case "7":
                        label7.Text = "水山蹇325";
                        break;
                    case "8":
                        label7.Text = "水地比217";
                        break;
                    default:
                        break;
                }

            }
           else  if (label5.Text =="7")
            {
                switch (label4.Text)
                {
                    case "1":
                        label7.Text = "山天大有279";
                        break;
                    case "2":
                        label7.Text = "山泽损334";
                        break;
                    case "3":
                        label7.Text = "山火贲264";
                        break;
                    case "4":
                        label7.Text = "山雷颐282";
                        break;
                    case "5":
                        label7.Text = "山风蛊252";
                        break;
                    case "6":
                        label7.Text = "山水蒙201";
                        break;
                    case "7":
                        label7.Text = "艮为山368";
                        break;
                    case "8":
                        label7.Text = "山地剥268";
                        break;
                    default:
                        break;
                }

            }
           else if (label5.Text == "8")
            {
                switch (label4.Text)
                {
                    case "1":
                        label7.Text = "地天泰228";
                        break;
                    case "2":
                        label7.Text = "地泽临255";
                        break;
                    case "3":
                        label7.Text = "地火明夷315";
                        break;
                    case "4":
                        label7.Text = "地雷复271";
                        break;
                    case "5":
                        label7.Text = "地风升349";
                        break;
                    case "6":
                        label7.Text = "地水师213";
                        break;
                    case "7":
                        label7.Text = "地山谦242";
                        break;
                    case "8":
                        label7.Text = "坤为地196";
                        break;
                    default:
                        break;
                }

            }

           btnCalc.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            label4.Text = label5.Text = label6.Text = null;
            label7.Text = null;
            textBox1.Text = textBox2.Text = textBox3.Text = null;
            textBox4.Text = "明天涨跌走势如何";
            label8.Text = DateTime.Now.ToString();
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = label5.Text = label6.Text = "0";
            label7.Text = null;

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 3)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 3)
            {
                textBox3.Focus();
            }

        }
        //变爻输入框
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 3)
            {
                btnCalc.Focus();
            }

        }
        //求测事件输入框
        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
                {
                     textBox1.Focus();
                }
        }
        //变爻按下回车键
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
            {
                this.btnCalc_Click(sender, e);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBox1.TabIndex = 0;
            textBox1.Focus();
        }
        /*保存卦*/
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog SavaData = new SaveFileDialog();                                                          
            SavaData.Title = "保存文件";                        
            SavaData.InitialDirectory =@"D:\断卦";               
            SavaData.Filter = "TXT文件(*.txt)|*.txt";
            SavaData.FileName = DateTime.Now.ToLongDateString().ToString() + textBox4.Text;
            /*用户可能还没有计算,错误操作点击了保存*/
            if (label6.Text == "0" )
            {
                MessageBox.Show("还没有计算");
              //  this.btnCalc_Click(sender, e);
                return;
            }

           else  if (label6.Text == null)
            {
                MessageBox.Show("还没有计算");
                //this.btnCalc_Click(sender, e);
                return;
            }
            else
            {
                /*已经计算完毕开始保存*/
                SavaData.ShowDialog();
                string path = SavaData.FileName;
                if (path == "")
                {
                    return;
                }
                using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    string content ="时间:" + label8.Text+ "\r\n"+ "问事:" + textBox4.Text + "\r\n" + "下卦:" + label4.Text + "\r\n" + "上卦:" + label5.Text + "\r\n" + "变爻" + label6.Text + "\r\n" + "名页:" + label7.Text;
                    byte[] buffer = Encoding.Default.GetBytes(content);
                    fsWrite.Write(buffer, 0, buffer.Length);
                }
                MessageBox.Show("保存成功");
            }
  
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

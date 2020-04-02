using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_kkut
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();//not change

        }
        //form1 load messagebox print
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("艦これ編成メモリーにようこそ", "ようこそ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboBox1.Items.Add("戦艦");
            comboBox1.Items.Add("航空母艦");
            comboBox1.Items.Add("軽巡洋艦");
            comboBox1.Items.Add("駆逐艦");
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //resultにmessageboxを代入
            var result = MessageBox.Show("終了しますか?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        //ほかの編成をクリックし、新規ウィンドウを開く処理です
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();//class, instance?
            form2.Show();

            //
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {//キャプチャ処理をクラスにしたい
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
          
            bitmap.Save("c:\\kku\\1.png");
            bitmap.Dispose();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
           
            
           save.FileName = "team1.png";
            save.InitialDirectory = @"c:\kku";
            save.Title = "名前を付けて保存";
            save.RestoreDirectory = true;
            save.OverwritePrompt = true;
            save.CheckPathExists = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                Console.WriteLine(save.FileName);
            }
        }
        }

        
    }

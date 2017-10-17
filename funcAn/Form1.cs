using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace funcAn
{
    public partial class Form1 : Form
    {
        int val;
        Dictionary<int, string> arrayQW = new Dictionary<int, string>();
        Dictionary<string, string> arrayANS = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            // є ∈ ∀ ∃ ⊂ → ↦ ∪ ⋂
            //arrayQW.Add(0, ""); 
            //arrayANS.Add("", "");
            arrayQW.Add(0, "Метрическое пространство");
            arrayANS.Add("Метрическое пространство", "множество называется метрическим пространством, если ∀ x,y ∈X задано p(x,y)>=0 :  \r\n" +
                " 1) p(x,y) = 0 <=> x=y  \r\n" +
                " 2) p(x,y) = p(y,x)  \r\n" +
                " 3) p(x,y) < p(x,z) + p(z,y)");

            arrayQW.Add(1, "Сходящаяся последовательность");
            arrayANS.Add("Сходящаяся последовательность", "Последовательность {Xn}⊂X называется сходящейся к x∈X, если p(Xn,X)→0, n→infinity");

            arrayQW.Add(2, "Фундаментальная последовательность");
            arrayANS.Add("Фундаментальная последовательность", "последовательность {Xn}⊂X называется фундаментальной, если p(Xn,Xm)→0  n,m→infinity ");

            arrayQW.Add(3, "Полное пространство");
            arrayANS.Add("Полное пространство", "Пространство полное, если каждая фундаментальная последовательность в нем сходящаяся");

            arrayQW.Add(4, "Открытый шар");
            arrayANS.Add("Открытый шар", "Открытый шар с центром в а: B(a,r) = {x∈X: p(x,a) < r}");

            arrayQW.Add(5, "Замкнутый шар");
            arrayANS.Add("Замкнутый шар", "Замкнутый шар с центром в а: B(a,r) = {x∈X: p(x,a) <=r}");

            arrayQW.Add(6, "Ограниченное множество");
            arrayANS.Add("Ограниченное множество", "Множество M⊂X ограничено: ∃B^(a,r): M⊂B(a,r)");

            arrayQW.Add(7, "Внутренняя точка");
            arrayANS.Add("Внутренняя точка", "M⊂X, a∈M, a- внутренняя, если ∃ r>0: B(a,r)⊂M");

            arrayQW.Add(8, "Открытое множество");
            arrayANS.Add("Открытое множество", "М - открытое множество , если все его точки внутренние");

            arrayQW.Add(9, "Предельная точка");
            arrayANS.Add("Предельная точка", "a∈X, M⊂X, a - предельная точка множества M, если ∃Xк∈M :{Xк}→a");
            // є ∈ ∀ ∃ ⊂ → ↦ ∪ ⋂
            arrayQW.Add(10, "Замыкание");
            arrayANS.Add("Замыкание", "Замыканием (М^) множества М : M^∪{предельные точки}");

            arrayQW.Add(11, "Замкнутое множество");
            arrayANS.Add("Замкнутое множество", "Множество М замкнуто, если М = M^(⊂ все свои предельные точки) ");

            arrayQW.Add(12, "Граничная точка");
            arrayANS.Add("Граничная точка", "a∈X - граничная точка Множества M ∀ r>0 ∃x∈");

            /*
                arrayQW.Add(13, "");
                arrayANS.Add("", "");

                arrayQW.Add(14, "");
                arrayANS.Add("", "");

                arrayQW.Add(15, "");
                arrayANS.Add("", "");

                arrayQW.Add(16, "");
                arrayANS.Add("", "");

                arrayQW.Add(17, "");
                arrayANS.Add("", "");

                arrayQW.Add(18, "");
                arrayANS.Add("", "");

                arrayQW.Add(19, "");
                arrayANS.Add("", "");

                arrayQW.Add(20, "");
                arrayANS.Add("", "");

                arrayQW.Add(21, "");
                arrayANS.Add("", "");

                arrayQW.Add(22, "");
                arrayANS.Add("", "");

                arrayQW.Add(23, "");
                arrayANS.Add("", "");
            */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            val = rng.Next(11);

            textBox3.Text = arrayQW[val];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox2.Text = arrayANS[arrayQW[val]];
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

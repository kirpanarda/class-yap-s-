using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        class dikdortgen { 
        private int a,b;
            public dikdortgen (int a,int b){
                this.a = a;
                this.b = b;
            }

            public int alanhesapla()
            {
                return this.a * this.b;
            }
            public int cevrehesapla()
            {
                return 2 * (this.a + this.b);
            }
        
        
        
        
        
        }
       
            

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dikdortgen diktorgenclass = new dikdortgen(10, 20);
        }
    }
}

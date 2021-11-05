using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CenaFilosofo
{
    public partial class Form1 : Form
    {
        //Variables
        private static int[] palillos = new int[5];//Palillos
        private static int[] comidas = new int[5];
        //semaforos
        static Semaphore semaforoP1 = new Semaphore(2, 2);
        //HILOS
        void hilo1()
        {
            semaforoP1.WaitOne();
            //Console.WriteLine("F1 tiene palillos" + palillos[1]);
            btn_p1.BackColor = Color.Red;
            btn_f1C.BackColor = Color.Green;
            Thread.Sleep(1500);
            //Console.WriteLine("F1 tiene palillos" + palillos[0]);
            btn_p5.BackColor = Color.Red;
            Thread.Sleep(1500);
            //Console.WriteLine("Ha comido F1");
            btn_p1.BackColor = Color.Purple;
            btn_p5.BackColor = Color.Purple;
            btn_f1C.BackColor = Color.Purple;
            comidas[0] += 1;
            txt_f1.Text = comidas[0].ToString();
            Thread.Sleep(1500);
            //Console.WriteLine("F1 dejo palillos");
            //Console.WriteLine("F1 dejo palillos");
            btn_p1.BackColor = Color.Teal;
            btn_p5.BackColor = Color.Teal;
            btn_f1C.BackColor = Color.Pink;
            Thread.Sleep(1500);
            semaforoP1.Release();
            //Thread.Sleep(1000);
        }

        void hilo2()
        {
            semaforoP1.WaitOne();
            //Console.WriteLine("F2 tiene palillos" + palillos[2]);
            btn_p1.BackColor = Color.Red;
            btn_f2C.BackColor = Color.Green;
            Thread.Sleep(1500);
            //Console.WriteLine("F2 tiene palillos" + palillos[1]);
            btn_p2.BackColor = Color.Red;
            Thread.Sleep(1500);
            //Console.WriteLine("Ha comido F2");
            btn_p1.BackColor = Color.Purple;
            btn_p2.BackColor = Color.Purple;
            btn_f2C.BackColor = Color.Purple;
            comidas[1] += 1;
            txt_f2.Text = comidas[1].ToString();
            Thread.Sleep(1500);;
            //Console.WriteLine("F2 dejo palillos" + palillos[2]);
            //Console.WriteLine("F2 dejo palillos" + palillos[1]);
            btn_p1.BackColor = Color.Teal;
            btn_p2.BackColor = Color.Teal;
            btn_f2C.BackColor = Color.Pink;
            Thread.Sleep(1500);
            semaforoP1.Release();
        }
        void hilo3()
        {
            semaforoP1.WaitOne();
            //Console.WriteLine("F3 tiene palillos" + palillos[3]);
            btn_p3.BackColor = Color.Red;
            btn_f3C.BackColor = Color.Green;
            Thread.Sleep(1500);
            //Console.WriteLine("F3 tiene palillos" + palillos[2]);
            btn_p2.BackColor = Color.Red;
            Thread.Sleep(1500);
            //Console.WriteLine("Ha comido F3");
            btn_p2.BackColor = Color.Purple;
            btn_p3.BackColor = Color.Purple;
            btn_f3C.BackColor = Color.Purple;
            comidas[2] += 1;
            txt_f3.Text = comidas[2].ToString();
            Thread.Sleep(1500);
            //Console.WriteLine("F3 dejo palillos" + palillos[2]);
            //Console.WriteLine("F3 dejo palillos" + palillos[1]);
            btn_p2.BackColor = Color.Teal;
            btn_p3.BackColor = Color.Teal;
            btn_f3C.BackColor = Color.Pink;
            Thread.Sleep(1500);
            semaforoP1.Release();
        }
        void hilo4()
        {
            semaforoP1.WaitOne();
            //Console.WriteLine("F4 tiene palillos" + palillos[4]);
            btn_p3.BackColor = Color.Red;
            btn_f4C.BackColor = Color.Green;
            Thread.Sleep(1500);
            //Console.WriteLine("F4 tiene palillos" + palillos[3]);
            btn_p4.BackColor = Color.Red;
            Thread.Sleep(1500);
            //Console.WriteLine("Ha comido F4");
            btn_p3.BackColor = Color.Purple;
            btn_p4.BackColor = Color.Purple;
            btn_f4C.BackColor = Color.Purple;
            comidas[3] += 1;
            txt_f4.Text = comidas[3].ToString();
            Thread.Sleep(1500);
            //Console.WriteLine("F4 dejo palillos" + palillos[2]);
            //Console.WriteLine("F4 dejo palillos" + palillos[1]);
            btn_p3.BackColor = Color.Teal;
            btn_p4.BackColor = Color.Teal;
            btn_f4C.BackColor = Color.Pink;
            Thread.Sleep(1500);
            semaforoP1.Release();
        }
        void hilo5()
        {

            semaforoP1.WaitOne();
            //Console.WriteLine("F5 tiene palillos" + palillos[0]);
            btn_p5.BackColor = Color.Red;
            btn_f5C.BackColor = Color.Green;
            Thread.Sleep(1500);
            //Console.WriteLine("F5 tiene palillos" + palillos[4]);
            btn_p4.BackColor = Color.Red;
            Thread.Sleep(1500);
            //Console.WriteLine("Ha comido F5");
            btn_p5.BackColor = Color.Purple;
            btn_p4.BackColor = Color.Purple;
            btn_f5C.BackColor = Color.Purple;
            comidas[4] += 1;
            txt_f5.Text = comidas[4].ToString();
            Thread.Sleep(1500);
            //Console.WriteLine("F5 dejo palillos" + palillos[2]);
            //Console.WriteLine("F5 dejo palillos" + palillos[1]);
            btn_p4.BackColor = Color.Teal;
            btn_p5.BackColor = Color.Teal;
            btn_f5C.BackColor = Color.Pink;
            Thread.Sleep(1500);
            semaforoP1.Release();
        }
        //DATOS DE BOTONES
        /*Palillos
         * btn_p1
         * btn_p2
         * btn_p3
         * btn_p4
         * btn_p5
         */
        //Datos filosfos
        //btn_f1C
        //btn_f2C
        //btn_f3C
        //btn_f4C
        //btn_f5C
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            for (int i = 0; i < 5; i++)
            {
                palillos[i] = 1;
            }
            //Console.WriteLine("Termino la asigancion de palillos dentro del programa");
            Thread.Sleep(1000);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            btn_1.Enabled = false;
            for (int i = 0; i < 5; i++)
            {
                new Thread(hilo2).Start();
                new Thread(hilo4).Start();
                new Thread(hilo1).Start();
                new Thread(hilo3).Start();
                new Thread(hilo5).Start();

            }
        }
    }
}

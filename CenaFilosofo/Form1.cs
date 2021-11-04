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
        public static int j = 10;
        public static int i = 0;
        private static int[] palillos = new int[5];//Palillos
        static Form1 frm1 = new Form1();
        //semaforos
        static Semaphore semaforoP1 = new Semaphore(2, 2);
        static Semaphore semaforoP2 = new Semaphore(2, 2);
        static Semaphore semaforoP3 = new Semaphore(2, 2);
        static Semaphore semaforoP4 = new Semaphore(2, 2);
        static Semaphore semaforoP5 = new Semaphore(2, 2);
        //HILOS
        public static void hilo1()
        {
            semaforoP1.WaitOne();
            frm1.btn_p1.BackColor = Color.Cyan;
            //Console.WriteLine("F1-1: tomo palillo1 " + palillos[0]);
            semaforoP3.WaitOne();
            frm1.btn_p3.BackColor = Color.Cyan;
            //Console.WriteLine("F1-2: tomo palillo2 " + palillos[2]);
            //Console.WriteLine("F1-1 Comiendo");
            Thread.Sleep(1000);
            semaforoP3.Release();
            //Console.WriteLine("F1 SOLTO PALILLO 2");
            frm1.btn_p1.BackColor = Color.White;
            frm1.btn_p3.BackColor = Color.White;
            Thread.Sleep(1000);
            semaforoP1.Release();
            //Console.WriteLine("F1 DEJO PALILLOS --- DEJO DE COMER");
            //Thread.Sleep(1000);
        }

        public static void hilo2()
        {
            semaforoP1.WaitOne();
            frm1.btn_p2.BackColor = Color.Cyan;

            //Console.WriteLine("F2-1: tomo palillo1 " + palillos[1]);
            semaforoP2.WaitOne();
            frm1.btn_p1.BackColor = Color.Cyan;
            //Console.WriteLine("F2-2: tomo palillo2 " + palillos[0]);
            //Console.WriteLine("F2-1 Comiendo");
            Thread.Sleep(1000);
            semaforoP2.Release();
            //Console.WriteLine("F2 SOLTO PALILLO 2");
            frm1.btn_p2.BackColor = Color.White;
            frm1.btn_p1.BackColor = Color.White;
            Thread.Sleep(1000);
            semaforoP1.Release();
            //Console.WriteLine("F2 DEJO PALILLOS --- DEJO DE COMER");
            //Thread.Sleep(1000);
        }
        static void hilo3()
        {
            semaforoP3.WaitOne();
            frm1.btn_p3.BackColor = Color.Cyan;
            //Console.WriteLine("F3-1: tomo palillo1 " + palillos[2]);
            semaforoP1.WaitOne();
            frm1.btn_p1.BackColor = Color.Cyan;
            //Console.WriteLine("F3-2: tomo palillo2 " + palillos[0]);
            //Console.WriteLine("F3-1 Comiendo");
            Thread.Sleep(1000);
            semaforoP1.Release();
            //Console.WriteLine("F2 SOLTO PALILLO 2");
            frm1.btn_p3.BackColor = Color.White;
            frm1.btn_p1.BackColor = Color.White;
            Thread.Sleep(1000);
            semaforoP3.Release();
            //Console.WriteLine("F3 DEJO PALILLOS --- DEJO DE COMER");
            //Thread.Sleep(1000);
        }

        static void colores()
        {
            frm1.btn_p1.BackColor = Color.Red;
            

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
            for (int i = 0; i < 5; i++)
            {
                palillos[i] = 1;
            }
            //Console.WriteLine("Termino la asigancion de palillos dentro del programa");
            Thread.Sleep(1000);
            //for (int i = 0; i < 5; i++)
            //{
            //    new Thread(hilo1).Start();
            //    new Thread(hilo2).Start();
            //    new Thread(hilo3).Start();
            //}
            new Thread(colores).Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

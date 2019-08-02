using COMP123_Summer2019.Models;
using COMP123_Summer2019.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Summer2019
{
   public static class Program
    {
        //static members 
        public static Product product;
        public static SplashForm splashForm;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static AboutForm aboutForm;
        public static OrderForm orderForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //instantiate all forms here
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            startForm = new StartForm();
            splashForm = new SplashForm();
            selectForm = new SelectForm();
            orderForm = new OrderForm();
            productInfoForm = new ProductInfoForm();
            aboutForm = new AboutForm();
            product = new Product();
            Application.Run(splashForm);
        }
    }
}

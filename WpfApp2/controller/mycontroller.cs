using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;
using WpfApp2.views;
using System.Windows.Controls;
namespace WpfApp2.controller
{
   public class mycontroller : UIElement
    {
        MainWindow main;
        public Cmd cmdnavegar { get; set; }
        public mycontroller()
        {
            main = (MainWindow)App.Current.MainWindow;
            cmdnavegar = new Cmd(Navega,podenavegar);
        }
        #region Navegar
        public Boolean podenavegar(object pagina) {
            string pag = pagina.ToString();
            var paginacur = main.myframe.Content as Page;
            if (pag == paginacur.Title)
            {
                return false;
            }
            return true;
        }
        public void Navega(Object pagina) {
            string pag = pagina.ToString();
            switch(pag)
            {
                case "pagina1":
                    Page1 p = new Page1();
                    main.myframe.Navigate(p);
                    break;
                case "pagina2":
                    Page2 p2 = new Page2();
                    main.myframe.Navigate(p2);
                    break;
                case "pagina3":
                    Page3 p3 = new Page3();
                    main.myframe.Navigate(p3);
                    break;
            }
        }
        #endregion
    }
}

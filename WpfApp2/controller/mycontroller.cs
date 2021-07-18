using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Microsoft.Win32;
using System.IO;
using System.Text.RegularExpressions;
using WpfApp2.views;
using WpfApp2.model;
using System.Data.SqlClient;

namespace WpfApp2.controller
{
    public class mycontroller : UIElement
    {
        MainWindow main;
        public Cmd cmdnavegar { get; set; }
        public Cmd cmdinserirlivro { get; set; }


        public mycontroller()
        {
            main = (MainWindow)App.Current.MainWindow;
            cmdnavegar = new Cmd(Navega, podenavegar);
            cmdinserirlivro = new Cmd(inserirlivro, (parametro) => true);
            inilivro();

        }
        #region Navegar
        public Boolean podenavegar(object pagina)
        {
            string pag = pagina.ToString();
            var paginacur = main.myframe.Content as Page;
            if (pag == paginacur.Title)
            {
                return false;
            }
            return true;
        }
        public void Navega(Object pagina)
        {
            string pag = pagina.ToString();
            switch (pag)
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


        #region livros



        public ObservableCollection<livros> livros
        {
            get { return (ObservableCollection<livros>)GetValue(livrosProperty); }
            set { SetValue(livrosProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty livrosProperty =
            DependencyProperty.Register("livros",
                typeof(ObservableCollection<livros>),
                typeof(mycontroller), new PropertyMetadata(null));



        public ICollectionView Viewmarcar
        {
            get { return (ICollectionView)GetValue(ViewmarcarProperty); }
            set { SetValue(ViewmarcarProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Viewmarcar.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ViewmarcarProperty =
            DependencyProperty.Register("Viewmarcar", typeof(ICollectionView), typeof(mycontroller), new PropertyMetadata(null));


        public livros Clivro
        {
            get { return (livros)GetValue(ClivroProperty); }
            set { SetValue(ClivroProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Clivro.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClivroProperty =
            DependencyProperty.Register("Clivro", typeof(livros), typeof(mycontroller), new PropertyMetadata(null));




        public void inilivro()
        {
            using (basedadosEntities db = new basedadosEntities())
            {
                List<livros> livro = db.livros.ToList();
                livros = new ObservableCollection<livros>(livro);
                Viewmarcar = CollectionViewSource.GetDefaultView(livros);
                Viewmarcar.CurrentChanged += Viewmarcar_CurrentChanged;
                Clivro = (livros)Viewmarcar.CurrentItem;
            }

        }

        private void Viewmarcar_CurrentChanged(object sender, EventArgs e)
        {
            Clivro = Viewmarcar.CurrentItem as livros;
        }
        public void inserirlivro(object parameter)
        {
            using (basedadosEntities db = new basedadosEntities())
            {
                livros nova = new livros();
                db.livros.Add(nova);
                db.SaveChanges();
                inilivro();
                Viewmarcar.MoveCurrentToLast();
            }
        }
        #endregion
    }
}

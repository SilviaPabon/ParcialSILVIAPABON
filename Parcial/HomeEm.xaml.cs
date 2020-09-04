using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Parcial
{
    /// <summary>
    /// Lógica de interacción para HomeEm.xaml
    /// </summary>
    public partial class HomeEm : Page
    {
        public HomeEm()
        {
            InitializeComponent();
        }

        private void btnVender_Click(object sender, RoutedEventArgs e)
        {
            if (chkAliñado.IsChecked == true || chkNoaliñado.IsChecked == true || chkEspecial.IsChecked == true)
            {
                int aliñado = Convert.ToInt32(txtAliñ.Text) * 1000;
                int noAliñado = Convert.ToInt32(txtNoAli.Text) * 500;
                int especial = Convert.ToInt32(txtEspecial.Text) * 2000;
                string cédula = txtCC.Text;
                string nombre = txtName.Text;
                
                string text = "-The user: " + nombre + ", con CC: " + cédula + " compró: $" + aliñado + " de aliñado, $" + noAliñado + " de no aliñado, y $"+ especial + " de especial" + "\n";
                txtResults.Text += text;
            }
            else
            {
                int aliñado = 0;
                int noAliñado = 0;
                int especial = 0;
                string cédula = txtCC.Text;
                string nombre = txtName.Text;
                string text = "-The user: " + nombre + ", con CC: " + cédula + "compró: $" + aliñado + "de aliñado, $" + noAliñado + "de no aliñado, y $" + especial + "de especial" + "\n";
                txtResults.Text += text;
            }
        }
    }
}

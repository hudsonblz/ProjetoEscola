using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetoEscola
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BtnHome.Visibility = Visibility.Collapsed;
            txblTitulo.Text = BtnHome.Content.ToString();
            Conteudo.Navigate(new Home());
        }

        #region Funções 
        private void EsmaecerBotão(Button Botao)
        {
            BtnAlunos.Visibility = Visibility.Visible;
            BtnAtividades.Visibility = Visibility.Visible;
            BtnHome.Visibility = Visibility.Visible;
            BtnProfessores.Visibility = Visibility.Visible;
            BtnTurmas.Visibility = Visibility.Visible;

            Botao.Visibility = Visibility.Collapsed;
        }
        #endregion

        #region Botões
        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            Button EsseBotao = (Button)e.Source;
            txblTitulo.Text = EsseBotao.Content.ToString();
            EsmaecerBotão(EsseBotao);
        }

        private void BtnAlunos_Click(object sender, RoutedEventArgs e)
        {
            Button EsseBotao = (Button)e.Source;
            txblTitulo.Text = EsseBotao.Content.ToString();
            EsmaecerBotão(EsseBotao);
        }

        private void BtnTurmas_Click(object sender, RoutedEventArgs e)
        {
            Button EsseBotao = (Button)e.Source;
            txblTitulo.Text = EsseBotao.Content.ToString();
            EsmaecerBotão(EsseBotao);
        }

        private void BtnAtividades_Click(object sender, RoutedEventArgs e)
        {
            Button EsseBotao = (Button)e.Source;
            txblTitulo.Text = EsseBotao.Content.ToString();
            EsmaecerBotão(EsseBotao);
        }

        private void BtnProfessores_Click(object sender, RoutedEventArgs e)
        {
            Button EsseBotao = (Button)e.Source;
            txblTitulo.Text = EsseBotao.Content.ToString();
            EsmaecerBotão(EsseBotao);
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace UI.Usuario
{
    public partial class Inicial : PhoneApplicationPage
    {
        public  Inicial()
        {
            InitializeComponent();
            TextBlockNomeLogado.Text = (App.Current as App).NomeUsuarioLogado;                  
        }

        private void btnPaginaUsuario_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Usuario/Inicial.xaml", UriKind.Relative));
        }

        private void btnPaginaGrupo_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Grupo/Inicial.xaml", UriKind.Relative));
        }

        private async void buttonAtualizar_Click(object sender, RoutedEventArgs e)
        {
            List<Modelo.Usuario> amigos = await Modelo.Usuario.Listar();
            listBoxAmigos.ItemsSource = amigos;
        }

        private void buttonDeletar_Click(object sender, RoutedEventArgs e)
        {
            Modelo.Usuario.Deletar(listBoxAmigos.SelectedItem.ToString());
        }

        private void buttonAlterarUsuario_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Usuario/EditarUsuario.xaml", UriKind.Relative));
        }

        private void buttonNovaMs_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
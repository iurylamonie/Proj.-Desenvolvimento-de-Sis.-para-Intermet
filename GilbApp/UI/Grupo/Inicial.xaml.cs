using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace UI.Grupo
{
    public partial class Inicial : PhoneApplicationPage
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private async void buttonAtualizar_Click(object sender, RoutedEventArgs e)
        {
            List<Modelo.Grupo> grupos = await Modelo.Grupo.Listar((App.Current as App).IdUsuarioLogado);
            listBoxGrupos.ItemsSource = grupos;
        }

        private void buttonDeletar_Click(object sender, RoutedEventArgs e)
        {
            Modelo.Grupo.Deletar((listBoxGrupos.SelectedItem as Modelo.Grupo).Id);
        }

        private void buttonNovoGrupo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Grupo/NovoGrupo.xaml", UriKind.Relative));
        }

        private void btnPaginaUsuario_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Usuario/Inicial.xaml", UriKind.Relative));
        }

        private void btnPaginaGrupo_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Grupo/Inicial.xaml", UriKind.Relative));
        }

        private void buttonNovaMs_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Grupo/NovaMensagem.xaml", UriKind.Relative));
        }

        private void buttonDetalhar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Grupo/Membro/ListarMembros.xaml", UriKind.Relative));
        }
    }
}

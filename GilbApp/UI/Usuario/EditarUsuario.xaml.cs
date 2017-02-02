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
    public partial class EditarUsuario : PhoneApplicationPage
    {
        public EditarUsuario()
        {
            InitializeComponent();
            textBoxNovoNome.Text = (App.Current as App).NomeUsuarioLogado;
        }

        private void buttonAlterar_Click(object sender, RoutedEventArgs e)
        {
            Modelo.Usuario usuario = new Modelo.Usuario { Nome = textBoxNovoNome.Text };
            Modelo.Usuario.Alterar((App.Current as App).NomeUsuarioLogado, usuario);
            (App.Current as App).NomeUsuarioLogado = textBoxNovoNome.Text;
            NavigationService.Navigate(new Uri("/Usuario/inicial.xaml", UriKind.Relative));
        }

        private void buttonCancelar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
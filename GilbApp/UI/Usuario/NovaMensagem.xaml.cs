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
    public partial class NovaMensagem : PhoneApplicationPage
    {
        Modelo.Usuario usuarioDestinario;
        public NovaMensagem()
        {
            InitializeComponent();
            textBlockNomeUsuario.Text = (App.Current as App).NomeUsuarioLogado;
            textBlockDestinatario.Text = (App.Current as App).NomeUsuarioSelecionado;

           usuarioDestinario = Modelo.Usuario.PuxarUsuario((App.Current as App).NomeUsuarioSelecionado).Result;
        }

        private void buttonCanceler_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void buttonEnviar_Click(object sender, RoutedEventArgs e)
        {
            Modelo.Mensagem mensagem = new Modelo.Mensagem
            {
                Remetente = (App.Current as App).NomeUsuarioLogado,
                Conteudo = textBoxMensagem.Text
            };
            Modelo.Mensagem.Enviar(usuarioDestinario.Uri, mensagem);
        }
    }
}

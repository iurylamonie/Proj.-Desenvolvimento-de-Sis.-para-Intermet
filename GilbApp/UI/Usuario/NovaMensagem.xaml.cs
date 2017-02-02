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
        public NovaMensagem()
        {
            InitializeComponent();
            TextBlockNomeLogado.Text = (App.Current as App).NomeUsuarioLogado;
        }

        private void buttonCanceler_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void buttonEnviar_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

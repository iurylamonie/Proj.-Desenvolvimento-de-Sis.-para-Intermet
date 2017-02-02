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
    public partial class EditarGrupo : PhoneApplicationPage
    {
        public EditarGrupo()
        {
            InitializeComponent();
            textBoxNovoGrupo.Text = (App.Current as App).DescricaoGrupoSelecionado;
        }

        private void buttonCancelar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void buttonAlterar_Click(object sender, RoutedEventArgs e)
        {
            Modelo.Grupo grupo = new Modelo.Grupo
            {
                Id = (App.Current as App).IdGrupoSelecionado,
                Descricao = textBoxNovoGrupo.Text
            };
            
            Modelo.Grupo.Alterar(grupo);
            (App.Current as App).IdGrupoSelecionado = 0;
            (App.Current as App).DescricaoGrupoSelecionado = "";
            NavigationService.Navigate(new Uri("/Grupo/inicial.xaml", UriKind.Relative));
        }
    }
}

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
        public Inicial()
        {
            InitializeComponent();
            TextBlockNomeLogado.Text = (App.Current as App).NomeUsuarioLogado;
        }
    }
}
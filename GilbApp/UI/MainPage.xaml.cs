using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using UI.Resources;
using Microsoft.Phone.Notification;
using System.Text;

namespace UI
{
    public partial class MainPage : PhoneApplicationPage
    {
        private string nomeCanal = "whatsCanal";
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private async void buttonEntrar_Click(object sender, RoutedEventArgs e)
        {
            (App.Current as App).NomeUsuarioLogado = textBoxNomeUsuario.Text;
            NavigationService.Navigate(new Uri("/Usuario/Inicial.xaml", UriKind.Relative));
            (App.Current as App).IdUsuarioLogado = 1;
            HttpNotificationChannel canalPush = HttpNotificationChannel.Find(nomeCanal);

            try
            {
                if (canalPush == null)
                {
                    //canal não existe
                    if (await Modelo.Usuario.ConsultarPorNome(textBoxNomeUsuario.Text) == "")
                    {
                        //Usuario existe
                        canalPush = new HttpNotificationChannel(nomeCanal);
                        canalPush.ChannelUriUpdated += new EventHandler<NotificationChannelUriEventArgs>(AtualizarUriCanal);
                        canalPush.ErrorOccurred += new EventHandler<NotificationChannelErrorEventArgs>(CanalPush_ErrorOccurred);
                        canalPush.ShellToastNotificationReceived += new EventHandler<NotificationEventArgs>(PushChannel_ShellToastNotificationReceived);
                        canalPush.Open();
                        canalPush.BindToShellToast();
                    }
                    else
                    {
                        //Usuario não existe
                        canalPush = new HttpNotificationChannel(nomeCanal);
                        canalPush.ChannelUriUpdated += new EventHandler<NotificationChannelUriEventArgs>(CriarUriCanal);
                        canalPush.ErrorOccurred += new EventHandler<NotificationChannelErrorEventArgs>(CanalPush_ErrorOccurred);
                        canalPush.ShellToastNotificationReceived += new EventHandler<NotificationEventArgs>(PushChannel_ShellToastNotificationReceived);
                        canalPush.Open();
                        canalPush.BindToShellToast();
                    }
                }
                else
                {
                    //Canal existe
                    if (await Modelo.Usuario.ConsultarPorNome(textBoxNomeUsuario.Text) != "")
                    {
                        //Usuario existe
                        canalPush.ChannelUriUpdated += new EventHandler<NotificationChannelUriEventArgs>(AtualizarUriCanal);
                        canalPush.ErrorOccurred += new EventHandler<NotificationChannelErrorEventArgs>(CanalPush_ErrorOccurred);
                        canalPush.ShellToastNotificationReceived += new EventHandler<NotificationEventArgs>(PushChannel_ShellToastNotificationReceived);
                    }
                    else
                    {
                        //Usuario não existe
                        canalPush.ChannelUriUpdated += new EventHandler<NotificationChannelUriEventArgs>(CriarUriCanal);
                        canalPush.ErrorOccurred += new EventHandler<NotificationChannelErrorEventArgs>(CanalPush_ErrorOccurred);
                        canalPush.ShellToastNotificationReceived += new EventHandler<NotificationEventArgs>(PushChannel_ShellToastNotificationReceived);
                    }
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Olha o errro ai!");
            }
        }
        
         private void AtualizarUriCanal(object sender, NotificationChannelUriEventArgs e)
        {
            Dispatcher.BeginInvoke(
                () => {
                    System.Diagnostics.Debug.WriteLine(e.ChannelUri.ToString());
                    Modelo.Usuario u = new Modelo.Usuario
                    {
                        Nome = textBoxNomeUsuario.Text,
                        Uri = e.ChannelUri.ToString()
                    };
                    Modelo.Usuario.AlterarUri(u);
                }
                );
        }

        private void CriarUriCanal(object sender, NotificationChannelUriEventArgs e)
        {
            Dispatcher.BeginInvoke(
                () => {
                    System.Diagnostics.Debug.WriteLine(e.ChannelUri.ToString());
                    Modelo.Usuario u = new Modelo.Usuario
                    {
                        Nome = textBoxNomeUsuario.Text,
                        Uri = e.ChannelUri.ToString()
                    };
                    Modelo.Usuario.Inserir(u);
                }
                );
        }

        private void CanalPush_ErrorOccurred(object sender, NotificationChannelErrorEventArgs e)
        {
            Dispatcher.BeginInvoke(() =>
                MessageBox.Show(String.Format("A push notification {0} error occurred.  {1} ({2}) {3}",
                    e.ErrorType, e.Message, e.ErrorCode, e.ErrorAdditionalData))
                    );
        }

        private void PushChannel_ShellToastNotificationReceived(object sender, NotificationEventArgs e)
        {
            StringBuilder message = new StringBuilder();
            string relativeUri = string.Empty;

            message.AppendFormat("Mensagem Recebida às {0}:\n", DateTime.Now.ToShortTimeString());

            // Parse out the information that was part of the message.
            foreach (string key in e.Collection.Keys)
            {
                message.AppendFormat("{0}: {1}\n", key, e.Collection[key]);

                if (string.Compare(
                    key,
                    "wp:Param",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.CompareOptions.IgnoreCase) == 0)
                {
                    relativeUri = e.Collection[key];
                }
                Dispatcher.BeginInvoke(() => MessageBox.Show(message.ToString()));
            }
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}

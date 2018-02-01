using BotOnXamarin.Forms.Models;
using BotOnXamarin.Forms.MVVMShared;
using BotOnXamarin.Forms.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace BotOnXamarin.Forms.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public RelayCommand SendCommand { get; private set; }
        ObservableCollection<BotMessage> _botMessages;
        public ObservableCollection<BotMessage> BotMessages
        {
            get => _botMessages;
            set => SetProperty(ref _botMessages, value);
        }
        BotConnectorService _botService;
        private string _currentMessage;
        public string CurrentMessage
        {
            get => _currentMessage; 
            set => SetProperty(ref _currentMessage, value); 
        }


        public MainViewModel()
        {
            _botService = new BotConnectorService();
            SendCommand = new RelayCommand(async () => await SendMessage());
            BotMessages = new ObservableCollection<BotMessage>();
        }

        private async Task SendMessage()
        {

        }
    }
}

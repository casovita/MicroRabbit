using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _accountRepository;
        private readonly IEventBus _eventBus;

        public TransferService(ITransferRepository transferRepository, IEventBus eventBus)
        {
            _accountRepository = transferRepository ?? throw new ArgumentNullException(nameof(transferRepository));
            _eventBus = eventBus ?? throw new ArgumentNullException(nameof(eventBus));
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _accountRepository.GetTransferLogs();
        }
    }
}

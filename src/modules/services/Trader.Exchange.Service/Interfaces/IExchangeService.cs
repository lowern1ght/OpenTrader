﻿namespace Trader.Exchange.Service.Interfaces;

public interface IExchangeService
{
    Task<IEnumerable<Models.Exchange>> CollectionAsync(CancellationToken token);
}
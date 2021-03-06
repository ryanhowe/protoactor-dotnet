﻿// -----------------------------------------------------------------------
//  <copyright file="IProviderState.cs" company="Asynkron HB">
//      Copyright (C) 2015-2017 Asynkron HB All rights reserved
//  </copyright>
// -----------------------------------------------------------------------

using System;
using System.Threading.Tasks;

namespace Proto.Persistence
{
    public interface IProviderState
    {
        Task GetEventsAsync(string actorName, ulong indexStart, Action<object> callback);
        Task<Tuple<object, ulong>> GetSnapshotAsync(string actorName);
        Task PersistEventAsync(string actorName, ulong index, object data);
        Task PersistSnapshotAsync(string actorName, ulong index, object data);
        Task DeleteEventsAsync(string actorName, ulong fromIndex);
        Task DeleteSnapshotsAsync(string actorName, ulong fromIndex);
    }
}
﻿using Cysharp.Threading.Tasks;

namespace BeardPhantom.Fabric.Core
{
    public interface IInitable
    {
        #region Methods

        UniTask InitAsync();

        #endregion
    }
}
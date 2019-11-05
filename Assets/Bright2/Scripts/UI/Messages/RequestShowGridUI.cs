﻿using System.Collections.Generic;
using HK.Bright2.Database;
using HK.Bright2.GameSystems;
using HK.Bright2.WeaponControllers;
using HK.Framework.EventSystems;
using UnityEngine;
using UnityEngine.Assertions;

namespace HK.Bright2.UIControllers.Messages
{
    /// <summary>
    /// グリッドUIの表示をリクエストするメッセージ
    /// </summary>
    public sealed class RequestShowGridUI : Message<RequestShowGridUI, IEnumerable<IIconHolder>>
    {
        public IEnumerable<IIconHolder> Items => this.param1;
    }
}
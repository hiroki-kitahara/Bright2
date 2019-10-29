﻿using UnityEngine;
using UnityEngine.Assertions;
using HK.Bright2.ActorControllers;
using HK.Framework.EventSystems;

namespace HK.Bright2.UIControllers.Messages
{
    /// <summary>
    /// <see cref="ActorInstanceStatusController.PossessionWeapons">のインデックスを選択した際のメッセージ
    /// </summary>
    public sealed class SelectInstanceWeaponIndex : Message<SelectInstanceWeaponIndex, int>
    {
        public int Index => this.param1;
    }
}
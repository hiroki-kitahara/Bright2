﻿using HK.Framework.EventSystems;
using UnityEngine;
using UnityEngine.Assertions;

namespace HK.Bright2.ActorControllers.Messages
{
    /// <summary>
    /// <see cref="Actor"/>が移動したことを通知するメッセージ
    /// </summary>
    public sealed class Move : Message<Move>
    {
    }

    /// <summary>
    /// <see cref="Actor"/>が停止したことを通知するメッセージ
    /// </summary>
    public sealed class Idle : Message<Idle>
    {
    }
}
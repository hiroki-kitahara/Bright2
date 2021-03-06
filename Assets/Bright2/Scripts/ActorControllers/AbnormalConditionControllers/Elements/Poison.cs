﻿using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.Assertions;

namespace HK.Bright2.ActorControllers.AbnormalConditionControllers.Elements
{
    /// <summary>
    /// 状態異常の毒を制御するクラス
    /// </summary>
    public sealed class Poison : PoisonBase
    {
        public override Constants.AbnormalStatus Type => Constants.AbnormalStatus.Poison;

        protected override int DamageSplitCount => 5;

        protected override ActorContext.AbnormalConditionParameters.PoisonParameter GetParameter(Actor owner)
        {
            return owner.Context.AbnormalCondition.Poison;
        }
    }
}

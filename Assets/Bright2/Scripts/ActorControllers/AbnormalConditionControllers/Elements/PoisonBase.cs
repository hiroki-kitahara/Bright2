﻿using System;
using HK.Bright2.GameSystems;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.Assertions;

namespace HK.Bright2.ActorControllers.AbnormalConditionControllers.Elements
{
    /// <summary>
    /// ダメージを受ける状態異常を制御する抽象クラス
    /// </summary>
    public abstract class PoisonBase : AbnormalCondition
    {
        /// <summary>
        /// ダメージを与える分割数
        /// </summary>
        protected abstract int DamageSplitCount { get; }

        /// <summary>
        /// ダメージを受ける秒数
        /// </summary>
        protected abstract ActorContext.AbnormalConditionParameters.PoisonParameter GetParameter(Actor owner);

        public override IObservable<Unit> Attach(Actor owner)
        {
            return Observable.Create<Unit>((observer) =>
            {
                var poisonContext = this.GetParameter(owner);

                // 定期的に毒ダメージを与える
                Observable.Interval(TimeSpan.FromSeconds(poisonContext.Duration / DamageSplitCount))
                    .Take(DamageSplitCount)
                    .SubscribeWithState2(this, owner, (_, _this, _owner) =>
                    {
                        owner.StatusController.TakeDamage(Calculator.GetDamageResultOnPoison(_owner, _this.GetParameter(_owner), DamageSplitCount));
                    })
                    .AddTo(owner);

                // 毒時間を超えた場合に完了通知する
                Observable.Timer(TimeSpan.FromSeconds(poisonContext.Duration))
                    .SubscribeWithState(observer, (_, _observer) =>
                    {
                        _observer.OnNext(Unit.Default);
                        _observer.OnCompleted();
                    })
                    .AddTo(owner);

                return owner.OnDestroyAsObservable().Subscribe();
            });
        }

        public override void Detach()
        {
        }
    }
}

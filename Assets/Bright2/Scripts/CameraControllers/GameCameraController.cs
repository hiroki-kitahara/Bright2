﻿using HK.Bright2.GameSystems.Messages;
using HK.Framework.EventSystems;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.Assertions;

namespace HK.Bright2.CameraControllers
{
    /// <summary>
    /// ゲーム中に利用するカメラを制御するクラス
    /// </summary>
    public sealed class GameCameraController : MonoBehaviour
    {
        [SerializeField]
        private Cameraman cameraman = default;

        [SerializeField]
        private Transform target = default;

        void Awake()
        {
            Broker.Global.Receive<SpawnedActor>()
                .Where(x => x.Actor.tag == Tags.Name.Player)
                .SubscribeWithState(this, (x, _this) =>
                {
                    _this.target = x.Actor.CachedTransform;
                })
                .AddTo(this);
            this.LateUpdateAsObservable()
                .SubscribeWithState(this, (_, _this) =>
                {
                    _this.cameraman.CachedTransform.position = _this.target.position;
                });
        }
    }
}

﻿using UnityEngine;
using UnityEngine.Assertions;

namespace HK.Bright2.ActorControllers
{
    /// <summary>
    /// OnTriggerStay2D関数で<see cref="Actor"/>に対して様々な効果を付与するインターフェイス
    /// </summary>
    public interface IActorReactionOnTriggerStay2D
    {
        /// <summary>
        /// 処理を行う
        /// </summary>
        void Do(Actor actor);
    }
}

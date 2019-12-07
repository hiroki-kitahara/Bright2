﻿using UniRx;
using UnityEngine;
using UnityEngine.Assertions;

namespace HK.Bright2.ActorControllers.AIControllers
{
    /// <summary>
    /// <see cref="ScriptableObject"/>で作成可能な<see cref="IAIElement"/>
    /// </summary>
    public abstract class ScriptableAIElement : ScriptableObject, IAIElement
    {
        protected readonly CompositeDisposable events = new CompositeDisposable();
        
        public abstract void Enter(Actor owner);

        public virtual void Exit()
        {
            this.events.Clear();
        }
    }
}
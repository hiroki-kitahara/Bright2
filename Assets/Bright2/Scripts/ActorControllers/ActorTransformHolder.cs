﻿using UnityEngine;
using UnityEngine.Assertions;

namespace HK.Bright2.ActorControllers
{
    /// <summary>
    /// <see cref="Actor"/>を構成するのに必要な<see cref="Transform"/>を保持するクラス
    /// </summary>
    public sealed class ActorTransformHolder : MonoBehaviour
    {
        [SerializeField]
        private Transform leftEquipmentOrigin = default;
        /// <summary>
        /// 左方向の装備品の原点
        /// </summary>
        public Transform LeftEquipmentOrigin => this.leftEquipmentOrigin;

        [SerializeField]
        private Transform rightEquipmentOrigin = default;
        /// <summary>
        /// 右方向の装備品の原点
        /// </summary>
        public Transform RightEquipmentOrigin => this.rightEquipmentOrigin;

        private Actor owner;

        void Awake()
        {
            this.owner = this.GetComponent<Actor>();
            Assert.IsNotNull(this.owner);
        }

        public Transform GetEquipmentOrigin(Constants.Direction direction)
        {
            Assert.IsTrue(direction == Constants.Direction.Left || direction == Constants.Direction.Right);
            
            return direction == Constants.Direction.Left ? this.leftEquipmentOrigin : this.rightEquipmentOrigin;
        }
    }
}
﻿using UnityEngine;
using HK.Bright2.ActorControllers;
using HK.Framework.EventSystems;
using HK.Bright2.GameSystems.Messages;
using UnityEngine.Assertions;

namespace HK.Bright2.Extensions
{
    /// <summary>
    /// <see cref="Constants.Direction"/>に関する拡張関数
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        /// <see cref="Vector2"/>に変換して返す
        /// </summary>
        public static Vector2 ToVector2(this Constants.Direction self)
        {
            switch(self)
            {
                case Constants.Direction.Left:
                    return Vector2.left;
                case Constants.Direction.Right:
                    return Vector2.right;
                case Constants.Direction.Up:
                    return Vector2.up;
                case Constants.Direction.Down:
                    return Vector2.down;
                default:
                    Assert.IsTrue(false, $"{self}は未定義です");
                    return Vector2.zero;
            }
        }
    }
}
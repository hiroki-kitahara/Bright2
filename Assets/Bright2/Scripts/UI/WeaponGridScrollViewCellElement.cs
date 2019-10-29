﻿using HK.Bright2.Database;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

namespace HK.Bright2.UIControllers
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class WeaponGridScrollViewCellElement : MonoBehaviour
    {
        [SerializeField]
        private CanvasGroup canvasGroup = default;

        [SerializeField]
        private Image icon = default;

        [SerializeField]
        private CanvasGroup selectEffectCanvasGroup = default;

        public void Setup(WeaponRecord weaponRecord, bool isSelect)
        {
            this.icon.sprite = weaponRecord.Icon;
            this.canvasGroup.alpha = 1.0f;
            this.selectEffectCanvasGroup.alpha = isSelect ? 1.0f : 0.0f;
        }

        public void Deactive()
        {
            this.icon.sprite = null;
            this.canvasGroup.alpha = 0.0f;
            this.selectEffectCanvasGroup.alpha = 0.0f;
        }
    }
}
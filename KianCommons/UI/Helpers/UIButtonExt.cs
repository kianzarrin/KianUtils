namespace KianCommons.UI {
    using ColossalFramework.UI;
    using UnityEngine;

    public class UIButtonExt : UIButton {
        public static UIButtonExt Instance { get; private set; }

        public override void Awake() {
            base.Awake();
            Instance = this;
            name = nameof(UIButtonExt);

            height = 30f;
            textScale = 0.9f;
            normalBgSprite = "ButtonMenu";
            hoveredBgSprite = "ButtonMenuHovered";
            pressedBgSprite = "ButtonMenuPressed";
            disabledBgSprite = "ButtonMenuDisabled";
            disabledTextColor = new Color32(128, 128, 128, 255);
            canFocus = false;
        }

        public override void Start() {
            base.Start();
            width = parent.width;
        }
    }
}


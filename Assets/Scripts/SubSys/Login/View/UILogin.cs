﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILogin : UIBase
{
    public UILogin(int resId, UIType uiType) : base(resId, uiType)
    {
    }

    public UILogin(GameObject panel, GameObject parent, UIType uiType) : base(panel, parent, uiType)
    {
    }

    public override void Close()
    {
        base.Close();
    }

    public override void Create()
    {
        base.Create();
    }

    public override void Destroy()
    {
        base.Destroy();
    }

    public override void OnCreate()
    {
        base.OnCreate();
        GameObject okBtn = CommonHelper.FindChildByPath(this.Panel, "bottom/okBtn");
        Image titleImage = CommonHelper.GetComponentByPath<Image>(this.Panel, "logo");
        CommonHelper.AddBtnMsg(okBtn, (obj) =>
        {
            if (obj.name == "okBtn")
            {
                CommonHelper.SetImageSpriteFromAtlas(2001, titleImage, "airfightSheet_3", false);
            }
        });
        GUIHelper.GetMainCamera();
    }

    public override void OnDestroy()
    {
        base.OnDestroy();
    }

    public override void OnShow(bool isShow)
    {
        base.OnShow(isShow);
    }

    public override void Open()
    {
        base.Open();
    }

    public override void UpdateUI(EventData eventData)
    {
        base.UpdateUI(eventData);
    }
}
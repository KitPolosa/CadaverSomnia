﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnSwitchLang : MonoBehaviour
{
    [SerializeField]
    private LocalizationManager localizationManager;

    public void OnButtonClick()
    {
        localizationManager.CurrentLanguage = name;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] Animator settingsMenuAnimator;

    public void MaximizeSettingsMenu()
    {
        settingsMenuAnimator.SetTrigger("Maximize");
    }

    public void MinimizeSettingsMenu()
    {
        settingsMenuAnimator.SetTrigger("Minimize");
    }

}

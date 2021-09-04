using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePanel : MonoBehaviour
{
    public GameObject Panel;

    private void Update()
    {
        PressE();
    }

    public void OpenPanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }

    public void PressE()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Panel != null)
            {
                bool isActive = Panel.activeSelf;
                Panel.SetActive(!isActive);
            }
        }
    }

    public void ExitButton()
    {
        Panel.SetActive(false);
    }
}

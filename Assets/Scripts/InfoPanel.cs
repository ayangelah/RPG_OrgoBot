using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanel : MonoBehaviour
{
    [SerializeField] GameObject infoPanel;
    [SerializeField] GameObject inventory;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ExitInfoPanel();
        }
    }

    private void ExitInfoPanel()
    {
        infoPanel.SetActive(false);
        inventory.SetActive(true);
        Debug.Log("it should exit infopanel and re enable inventory now");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeClick : MonoBehaviour
{
    public GameObject infoPanel; // drag panel UI ke sini di Inspector

    void OnMouseDown()
    {
        infoPanel.SetActive(true);
        infoPanel.GetComponent<InfoPanelController>().ResetToFirstPage();
    }
}

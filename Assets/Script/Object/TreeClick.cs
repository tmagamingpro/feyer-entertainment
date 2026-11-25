using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeClick : MonoBehaviour
{
    public string[] pages; 
    void OnMouseDown()
    {
        InfoPanelController.Instance.ShowPanel(pages);
    }
}
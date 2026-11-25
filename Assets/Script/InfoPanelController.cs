using System.Collections;
using System.Collections.Generic;
using UnityEngine;  
using TMPro;

public class InfoPanelController : MonoBehaviour
{
    public static InfoPanelController Instance;

    public GameObject infoPanel; 
    public TMP_Text descriptionText; 
    public string[] currentPages; 

    public GameObject buttonPrev;
    public GameObject buttonNext;

    private int currentPage = 0;

    void Awake()
    {
        Instance = this;
        descriptionText.raycastTarget = false;
    }

    public void ShowPanel(string[] pagesData)
    {
        currentPages = pagesData;
        currentPage = 0;
        infoPanel.SetActive(true);
        UpdateText();
    }

    public void NextPage()
    {
        if (currentPage < currentPages.Length - 1)
        {
            currentPage++;
            UpdateText();
        }
    }

    public void PrevPage()
    {
        if (currentPage > 0)
        {
            currentPage--;
            UpdateText();
        }
    }

    void UpdateText()
    {
        descriptionText.text = currentPages[currentPage];
        UpdateButtonVisibility();
    }

    void UpdateButtonVisibility()
    {
        buttonPrev.SetActive(currentPage > 0);
        buttonNext.SetActive(currentPage < currentPages.Length - 1);
    }

        public void ClosePanel()
    {
        infoPanel.SetActive(false);
    }
}
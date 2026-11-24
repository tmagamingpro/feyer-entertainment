using System.Collections;
using System.Collections.Generic;
using UnityEngine;  
using TMPro;

public class InfoPanelController : MonoBehaviour
{
    public TMP_Text descriptionText; // atau TMP_Text kalau pakai TextMeshPro
    public string[] pages; // isi deskripsi tiap halaman

    public GameObject buttonPrev;
    public GameObject buttonNext;

    private int currentPage = 0;

    public void ResetToFirstPage()
    {
        currentPage = 0;
        UpdateText();
    }

    public void NextPage()
    {
        if (currentPage < pages.Length - 1)
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
        descriptionText.text = pages[currentPage];
        UpdateButtonVisibility();
    }

    void UpdateButtonVisibility()
    {
        buttonPrev.SetActive(currentPage > 0);
        buttonNext.SetActive(currentPage < pages.Length - 1);
    }
}
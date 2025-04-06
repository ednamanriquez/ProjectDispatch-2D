using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class TabController : MonoBehaviour
{
    public UnityEngine.UI.Image[] tabImages;
    public GameObject[] pages;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ActivateTab(0);
    }

    // Update is called once per frame
    public void ActivateTab(int tabNum)
    {
        for (int i = 0; i < pages.Length; i++)
        {
            pages[i].SetActive(false);
            tabImages[i].color = Color.gray;
        }
        pages[tabNum].SetActive(true);
        tabImages[tabNum].color = Color.white;
    }
}

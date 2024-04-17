using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UISceneMain : MonoBehaviour
{
    [SerializeField] private Button btnMenu;
    [SerializeField] private Button btnCloseMenu;

    [SerializeField] private Button btnLevel1;

    [SerializeField] Image imgMenu;

    private void Start()
    {
        btnMenu.onClick.AddListener(BtnOpenMenu);
        btnCloseMenu.onClick.AddListener(BtnCloseMenu);
        btnLevel1.onClick.AddListener(Level1);
    }

    private void BtnOpenMenu()
    {
        imgMenu.gameObject.SetActive(true);
    }

    private void BtnCloseMenu()
    {
        imgMenu.gameObject.SetActive(false);
    }

    private void Level1()
    {
        SceneManager.LoadScene(0);
    }
}

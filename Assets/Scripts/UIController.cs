using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Button btnRestart;
    [SerializeField] private Button btnPause;
    [SerializeField] private Button btnPlayAgain;
    [SerializeField] private Button btnMenuRestart;
    [SerializeField] private Button btnMenuPause;
    [SerializeField] private Image imgPause;

    private void Start()
    {
        btnRestart.onClick.AddListener(Restart);
        btnPause.onClick.AddListener(BtnPause);
        btnPlayAgain.onClick.AddListener(BtnPlayAgain);
        btnMenuPause.onClick.AddListener(BtnMenu);
        btnMenuRestart.onClick.AddListener(BtnMenu);
    }

    private void Restart()
    {
        SceneManager.LoadScene(0);
    }

    private void BtnPause()
    {
        imgPause.gameObject.SetActive(true);
        player.gameObject.SetActive(false);
    }

    private void BtnPlayAgain()
    {
        imgPause.gameObject.SetActive(false);
        player.gameObject.SetActive(true);
    }

    private void BtnMenu()
    {
        SceneManager.LoadScene(1);
    }
}

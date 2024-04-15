using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Image image;
    [SerializeField] private Button btnRestart;
    [SerializeField] private Button btnStart;

    private void Start()
    {
        player.SetActive(false);
        btnRestart.onClick.AddListener(Restart);
        btnStart.onClick.AddListener(StartGame);
    }

    private void StartGame() 
    {
        image.gameObject.SetActive(false);
        player.SetActive(true);
    }

    private void Restart()
    {
        SceneManager.LoadScene(0);
    }
}

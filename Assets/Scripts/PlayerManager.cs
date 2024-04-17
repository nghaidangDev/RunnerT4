using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private GameObject gameOver;

    [SerializeField] private Image imgWin;
    [SerializeField] private Button btnHome;

    private GameObject player;

    private void Start()
    {
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");

        btnHome.onClick.AddListener(BtnHome);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("DeadZone"))
        {
            gameOver.SetActive(true);
            Destroy(player.gameObject);
        }
        else if (collision.CompareTag("ZoneWin"))
        {
            GameWin();
            Destroy(player.gameObject);
        }

    }

    private void BtnHome()
    {
        SceneManager.LoadScene(2);
    }

    private void GameWin()
    {
        imgWin.gameObject.SetActive(true);
    }
}

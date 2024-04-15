using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private Text txtHp;
    private int hpCurrent = 3;
    [SerializeField] private GameObject gameOver;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        txtHp.text = "HP: " + hpCurrent;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("DeadZone"))
        {
            gameOver.SetActive(true);
            Destroy(player.gameObject);
        }else if (collision.CompareTag("Trap"))
        {
            hpCurrent -= 1;
            if (hpCurrent == 0)
            {
                Destroy(player.gameObject);
            }
        }
    }
}

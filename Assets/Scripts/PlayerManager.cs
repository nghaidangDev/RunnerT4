using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private GameObject gameOver;
    private GameObject player;

    private void Start()
    {
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("DeadZone"))
        {
            gameOver.SetActive(true);
            Destroy(player.gameObject);
        }
/*        else if (collision.CompareTag("Trap"))
        {
            anim.SetTrigger("hit");
            hpCurrent -= 1;

            if (hpCurrent == 0)
            {
                gameOver.SetActive(true);
                Destroy(player.gameObject);
            }
        }*/
    }
}

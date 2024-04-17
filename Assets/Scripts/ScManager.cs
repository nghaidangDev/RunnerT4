using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScManager : MonoBehaviour
{
    [SerializeField] private Button btn;
    [SerializeField] private Button btnMenu;
    [SerializeField] private Button btnCloseMenu;

    [SerializeField] Image imgMenu;

    private void Start()
    {
        btn.onClick.AddListener(PlayerGame);
    }

    private void PlayerGame()
    {
        SceneManager.LoadScene(2);
    }
}

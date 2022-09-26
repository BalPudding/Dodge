using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject overText;
    public TextMeshPro restartText;

    private bool isGameover;
    // Start is called before the first frame update
    void Start()
    {
        isGameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameover)
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("DodgeScene");
            }
        }
    }
    public void EndGame()
    {
        isGameover = true;
        overText.SetActive(true);

    }
}

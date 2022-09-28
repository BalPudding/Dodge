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
    public TextMeshProUGUI coolDownText;
    public PlayerCtrl pc;
    public float survivetime;

    private bool isGameover;
    // Start is called before the first frame update
    void Start()
    {
        isGameover = false;
        survivetime = 2.5f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameover)
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("DodgeScene");
            }
        }
        if (pc.cool == false)
        {
            survivetime -= Time.deltaTime;
            coolDownText.text = "Dash Cooldown : " + (int)survivetime;
        }
        if(pc.cool == true)
        {
            survivetime = 2.5f;
        }
    }
    public void EndGame()
    {
        isGameover = true;
        overText.SetActive(true);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float time;
    private bool isgameover;

    public GameObject gameovertext;
    public Text timetext;
    public Text besttimetext;

  
    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        isgameover = false;

        gameovertext.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(!isgameover)
        {
            time += Time.deltaTime;
            timetext.text = "Time:" + time;
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene"); //내가정한씬이름
            }
        }
    }

    public void EndGame()
    {
        isgameover = true;
        gameovertext.SetActive(true);

        float besttime = PlayerPrefs.GetFloat("BestTime", 0f);

        
        if(time>besttime)
        {
            besttime = time;
        }
        besttimetext.text = "BestTime:" + besttime;
    }


}

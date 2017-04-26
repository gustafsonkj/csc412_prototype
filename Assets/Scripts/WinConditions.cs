using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinConditions : MonoBehaviour {

    public int score;
    public bool won = false;
    public UnityEngine.UI.Text GameEndText;
    public UnityEngine.UI.Text scoreCount;


    // Use this for initialization
    void Start () {
		//if(true)
  //      {
  //          Debug.Log("US wins. MURICA");
  //      }
	}
	
	// Update is called once per frame
	void Update () {
        scoreCount.text = "Score: "+score;
        if (score > 99)
            USWin();
	}

    public IEnumerator wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);

    }
    public void USLose()
    {
        GameEndText.text = "USSR Wins";
        stopPlayers();
        StartCoroutine("wait",4.0f);

    }

    public void USWin()
    {
        won = true;
        GameEndText.text = "US Wins";
        stopPlayers();
        StartCoroutine("wait", 4.0f);
    }

    public void stopPlayers()
    {
        GameObject.Find("Player").GetComponent<PlayerController>().enabled = false;

        if (GameObject.Find("Player2") != null)
         GameObject.Find("Player2").GetComponent<PlayerController>().enabled = false;

    }
}

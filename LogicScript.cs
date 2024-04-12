using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject criticalityScreen;
    public bool criticality = false;
    public AudioSource dingalingSFX;
    public AudioSource geigeringSFX;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        dingalingSFX = audioSources[0];
        geigeringSFX = audioSources[1];
    }

    [ContextMenu("Increment Score")]
    public void incScore(int incre)
    {
        if (!criticality)
        {
            playerScore += incre;
            scoreText.text = playerScore.ToString();
            dingalingSFX.Play();
        }
    }

    public void tickleAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void goCritical()
    {
        criticalityScreen.SetActive(true);
        criticality = true;
        geigeringSFX.Play();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject rankCanvas;
    
    public AudioClip bgmClip;
    public AudioSource bgmSoundSource;

    private void Awake()
    {
        bgmSoundSource = GetComponent<AudioSource>();
        BGMStart();
    }
    public void BGMStart()
    {
        bgmSoundSource.Play();
        bgmSoundSource.loop = true;
    }
    private void Start()
    {
        gameOverCanvas.SetActive(false);
        rankCanvas.SetActive(false);
        Time.timeScale = 1;
    }
    
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }

    public void Ranking()
    {
        rankCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
    }
}

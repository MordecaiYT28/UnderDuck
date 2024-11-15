using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class playername : MonoBehaviour
{
    public TMP_InputField input;
    public RawImage video1;
    public VideoPlayer player;
    public AudioSource audioClip;
    public AudioSource misteryLullaby;

    private void Start()
    {
        video1.enabled = false;
        player.loopPointReached += EndReached;
    }
    public void SaveData()
    {
        string text = input.text;
        
        if (text != null)
        {
            PlayerPrefs.SetString("name", text);
            misteryLullaby.Stop();
            video1.enabled = true;
            player.Play();
            audioClip.Play();
        }
    }

    void EndReached(VideoPlayer video) 
    {
        SceneManager.LoadScene("world");
    }
}

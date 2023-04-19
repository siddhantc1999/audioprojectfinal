using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class buttonuimanager : MonoBehaviour
{

    public Texture pausesprite;
    public Texture playprite;
    public VideoPlayer currentvideo;
    public Canvas currentcanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //we will have to pass both the reference the videosource and play pause
    public void playpause(GameObject gameobject)
    {
        if (currentvideo.isPlaying)
        {
            currentvideo.Pause();
            gameobject.GetComponent<RawImage>().texture = pausesprite;


        }
        else
        {
            currentvideo.Play();
            gameobject.GetComponent<RawImage>().texture = playprite;
        }
    }
    public void fastforward()
    {
        currentvideo.time += 10f;
    }
    public void rewind()
    {
        currentvideo.time -= 10f;
    }
}

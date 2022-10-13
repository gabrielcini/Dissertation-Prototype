using AnotherFileBrowser.Windows;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.Video;

public class FileBrowserUpdate : MonoBehaviour
{
    GameObject screenObject;
    Renderer m_Renderer;
    Texture m_MainTexture;

    VideoPlayer videoPlayer;
    public VideoClip videoClip;

    public string pathString;

    void Start(){
      
      

      //Debug.Log("Movie Name: " + videoClip);

      //videoPlayer.clip = videoClip;
      //videoPlayer.Play();
    }

    void Update()
    {
        if (ScreenDisplay.screenObjectString == "Screen2")
        {
            screenObject = GameObject.Find("Screen2");
            m_Renderer = screenObject.GetComponent<Renderer>();

            videoPlayer = GetComponent<VideoPlayer>();
        }

        if (ScreenDisplay.screenObjectString == "Screen3")
        {
            screenObject = GameObject.Find("Screen3");
            m_Renderer = screenObject.GetComponent<Renderer>();

            videoPlayer = GetComponent<VideoPlayer>();
        }


    }

    public void OpenFileBrowser()
    {
        var bp = new BrowserProperties();
        bp.filter = "Custom Files (*.jpg;*.jpeg;*.png;*.mp4) | *.jpg;*.jpeg;*.png;*.mp4";
        bp.filterIndex = 0;

        new FileBrowser().OpenFileBrowser(bp, path =>
        {
            //Load image from local path with UWR
            Debug.Log(path);
            pathString = path;
            if (path.Contains(".mp4")){
              StartCoroutine(LoadVideo(path));
            }

            if(path.Contains(".jpg")){
              StartCoroutine(LoadImage(path));
            }

            if(path.Contains(".jpeg")){
              StartCoroutine(LoadImage(path));
            }

            if(path.Contains(".png")){
              StartCoroutine(LoadImage(path));
            }
            else {
              Debug.Log("Invalid File Extension");
            }

        });
    }

    public void RemoveOnMonitor()
    {
        if (pathString.Contains(".jpeg") || pathString.Contains(".jpg") || pathString.Contains(".png"))
        {
            m_Renderer.material.SetTexture("_MainTex", null);
        }
        if (pathString.Contains(".mp4"))
        {
            videoPlayer.Stop();
        }
        
    }

    //upload image from pc
    IEnumerator LoadImage(string path)
    {
        using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture(path))
        {
            yield return uwr.SendWebRequest();

            if (uwr.result == UnityWebRequest.Result.ConnectionError || uwr.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.Log(uwr.error);
            }
            else
            {
                videoPlayer.Stop();
                var uwrTexture = DownloadHandlerTexture.GetContent(uwr);
                m_MainTexture = uwrTexture;
                m_Renderer.material.SetTexture("_MainTex", m_MainTexture);
            }
        }
    }

    //upload image from pc
    IEnumerator LoadVideo(string path) {
      using (UnityWebRequest uwr = UnityWebRequest.Get(path))
      {
        yield return uwr.SendWebRequest();

        if(uwr.result == UnityWebRequest.Result.ConnectionError || uwr.result == UnityWebRequest.Result.ProtocolError) {
            Debug.Log(uwr.error);
        } else {
            videoPlayer.Stop();
            //File.WriteAllBytes("path/to/file", www.downloadHandler.data);
            //var uwrClip = VideoPlayer.GetContent(uwr);


            videoPlayer.url = path;
            //videoPlayer.clip = uwrClip;
            videoPlayer.Play();
        }
      }
    }
}

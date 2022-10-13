using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenDisplay : MonoBehaviour
{
    public GameObject uploadBtn;

    public static string screenObjectString;

    // Start is called before the first frame update
    void Start()
    {
        //uploadBtn = GameObject.Find("UploadFileBtn");
        //uploadBtn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Player detected");
            uploadBtn.SetActive(true);

            if (this.gameObject.name == "Monitor")
            {
                screenObjectString = "Screen2";
            }

            if (this.gameObject.name == "Monitor2")
            {
                screenObjectString = "Screen3";
            }
        }
    }

    void OnTriggerExit(Collider collision)
    {
        uploadBtn.SetActive(false);
    }
}

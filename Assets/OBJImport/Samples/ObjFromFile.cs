using AnotherFileBrowser.Windows;
using Dummiesman;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.Video;

public class ObjFromFile : MonoBehaviour
{
    string objPath = string.Empty;
    string error = string.Empty;
    string pathString;

    public static GameObject loadedObject, gameObject1, gameObject2, gameObject3, gameObject4, gameObject5, gameObject6;

    public void LoadOBJ() {
        var bp = new BrowserProperties();
        bp.filter = "Custom Files (*.obj;) | *.obj;";
        bp.filterIndex = 0;

        new FileBrowser().OpenFileBrowser(bp, path =>
        {
            pathString = path;
        });

        objPath = pathString;

        if (!File.Exists(objPath))
        {
            error = "File doesn't exist.";
        }
        else
        {
            if(loadedObject != null)            
                Destroy(loadedObject);
            loadedObject = new OBJLoader().Load(objPath);
            error = string.Empty;
        }

        if (PlayerMovement.collidedSocle)
        {
            GameObject socle = GameObject.Find("socle");
            gameObject1 = Instantiate(loadedObject);

            gameObject1.transform.position = GameObject.Find("socle").transform.position;
            gameObject1.transform.position = new Vector3(gameObject1.transform.position.x, 0.598f, gameObject1.transform.position.z);
        }

        if (PlayerMovement.collidedSocleOne)
        {
            GameObject socle = GameObject.Find("socle.001");
            gameObject2 = Instantiate(loadedObject);

            gameObject2.transform.position = GameObject.Find("socle.001").transform.position;
            gameObject2.transform.position = new Vector3(gameObject2.transform.position.x, 0.598f, gameObject2.transform.position.z);
        }

        if (PlayerMovement.collidedSocleTwo)
        {
            GameObject socle = GameObject.Find("socle.002");
            gameObject3 = Instantiate(loadedObject);

            gameObject3.transform.position = GameObject.Find("socle.002").transform.position;
            gameObject3.transform.position = new Vector3(gameObject3.transform.position.x, 0.598f, gameObject3.transform.position.z);
        }

        if (PlayerMovement.collidedSocleThree)
        {
            GameObject socle = GameObject.Find("socle.003");
            gameObject4 = Instantiate(loadedObject);

            gameObject4.transform.position = GameObject.Find("socle.003").transform.position;
            gameObject4.transform.position = new Vector3(gameObject4.transform.position.x, 0.598f, gameObject4.transform.position.z);
        }

        if (PlayerMovement.collidedSocleFour)
        {
            GameObject socle = GameObject.Find("socle.004");
            gameObject5 = Instantiate(loadedObject);

            gameObject5.transform.position = GameObject.Find("socle.004").transform.position;
            gameObject5.transform.position = new Vector3(gameObject5.transform.position.x, 0.598f, gameObject5.transform.position.z);
        }

        if (PlayerMovement.collidedSocleFive)
        {
            GameObject socle = GameObject.Find("socle.005");
            gameObject6 = Instantiate(loadedObject);

            gameObject6.transform.position = GameObject.Find("socle.005").transform.position;
            gameObject6.transform.position = new Vector3(gameObject6.transform.position.x, 0.598f, gameObject6.transform.position.z);
        }

        //loadedObject.transform.localScale = new Vector3(1f, 1f, 1f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleObjectSlider : MonoBehaviour
{
    public float size = 1;
    //GameObject loadedObject;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ObjFromFile.loadedObject = GameObject.Find("Midtown Auditorium Visualization");
        //loadedObject.transform.localScale = new Vector3(size, size, size);
        if (ObjFromFile.loadedObject != null)
        {
            if (slider != null)
            {
                ObjFromFile.loadedObject.transform.localScale = new Vector3(1, 1, 1) * (slider.value);
                ObjFromFile.loadedObject.SetActive(true);

                if (ObjFromFile.gameObject1 != null && PlayerMovement.collidedSocle)
                {
                    ObjFromFile.gameObject1.transform.localScale = new Vector3(1, 1, 1) * (slider.value);
                }

                if (ObjFromFile.gameObject2 != null && PlayerMovement.collidedSocleOne)
                {
                    ObjFromFile.gameObject2.transform.localScale = new Vector3(1, 1, 1) * (slider.value);
                }

                if (ObjFromFile.gameObject3 != null && PlayerMovement.collidedSocleTwo)
                {
                    ObjFromFile.gameObject3.transform.localScale = new Vector3(1, 1, 1) * (slider.value);
                }

                if (ObjFromFile.gameObject4 != null && PlayerMovement.collidedSocleThree)
                {
                    ObjFromFile.gameObject4.transform.localScale = new Vector3(1, 1, 1) * (slider.value);
                }

                if (ObjFromFile.gameObject5 != null && PlayerMovement.collidedSocleFour)
                {
                    ObjFromFile.gameObject5.transform.localScale = new Vector3(1, 1, 1) * (slider.value);
                }

                if (ObjFromFile.gameObject6 != null && PlayerMovement.collidedSocleFive)
                {
                    ObjFromFile.gameObject6.transform.localScale = new Vector3(1, 1, 1) * (slider.value);
                }
            }
            
        }
        
    }

    public void AdjustSize(float newSize)
    {
        size = newSize;
    }
}

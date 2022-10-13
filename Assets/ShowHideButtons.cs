using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideButtons : MonoBehaviour
{
    public GameObject[] pathfindingButtons;

    bool showPathfindingButtons;

    // Start is called before the first frame update
    void Start()
    {
        showPathfindingButtons = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (!showPathfindingButtons)
        {
            foreach (var btn2 in pathfindingButtons)
            {
                btn2.SetActive(false);
            }
        }
        else
        {
            foreach (var btn2 in pathfindingButtons)
            {
                btn2.SetActive(true);
            }
        }
    }

    public void ShowHidePathfindingButtons()
    {
        if (!showPathfindingButtons)
        {
            showPathfindingButtons = true;
        }
        else
        {
            showPathfindingButtons = false;
        }
    }
}

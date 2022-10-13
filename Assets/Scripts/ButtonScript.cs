using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public GameObject player;

    GameObject teleportDestination, grid, grid2ndFloor, grid3rdFloor;

    public GameObject teleportPanel;

    CharacterController cc;

    Animation animation;

    public Text fadeText;

    public GameObject uiPanel;

    public static string sentText;

    string stairsText;

    // Start is called before the first frame update
    void Start()
    {
        //teleportPanel = GameObject.Find("Teleport Panel");
        animation = teleportPanel.GetComponent<Animation>();
        //fadeText = GameObject.Find("TeleportText");
        grid = GameObject.Find("A*");
        grid2ndFloor = GameObject.Find("A* 2nd Floor");
        grid3rdFloor = GameObject.Find("A* 3rd Floor");
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMovement.enteredFirstFloor)
        {
            stairsText = "Collider 1st Floor";
        }

        if (PlayerMovement.enteredSecondFloor)
        {
            stairsText = "Collider 2nd Floor (1)";
        }

        if (PlayerMovement.enteredThirdFloor)
        {
            stairsText = "Collider 3rd Floor";
        }
    }

    public void GoToBlockM()
    {
        SceneManager.LoadScene("A_Star_Algorithm_Testing");
        MouseLook.GamePaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
    }

    public void GoToPresentationRoom()
    {
        SceneManager.LoadScene("Presentation Room");
        MouseLook.GamePaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
    }

    public void GoToExhibitionRoom()
    {
        SceneManager.LoadScene("Exhibition Room");
        MouseLook.GamePaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
    }

    public void Teleport(Dropdown target)
    {
        grid.SetActive(false);
        grid2ndFloor.SetActive(false);
        grid3rdFloor.SetActive(false);
        MouseLook.GamePaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        teleportPanel.SetActive(true);
        Time.timeScale = 1f;
        player = GameObject.Find("Player");


        if (target.value == 0)
        {
            teleportDestination = GameObject.Find("Class 1 1st Floor");
        }

        if (target.value == 1)
        {
            teleportDestination = GameObject.Find("Class 2 1st Floor");
        }

        if (target.value == 2)
        {
            teleportDestination = GameObject.Find("Class 3 1st Floor");
        }

        if (target.value == 3)
        {
            teleportDestination = GameObject.Find("Class 4 1st Floor");
        }

        if (target.value == 4)
        {
            teleportDestination = GameObject.Find("Class 5 1st Floor");
        }

        if (target.value == 5)
        {
            teleportDestination = GameObject.Find("Class 6 1st Floor");
        }

        if (target.value == 6)
        {
            teleportDestination = GameObject.Find("Class 7 1st Floor");
        }

        if (target.value == 7)
        {
            teleportDestination = GameObject.Find("Class 8 1st Floor");
        }

        if (target.value == 8)
        {
            teleportDestination = GameObject.Find("Class 1 2nd Floor");
        }

        if (target.value == 9)
        {
            teleportDestination = GameObject.Find("Class 2 2nd Floor");
        }

        if (target.value == 10)
        {
            teleportDestination = GameObject.Find("Class 3 2nd Floor");
        }

        if (target.value == 11)
        {
            teleportDestination = GameObject.Find("Class 4 2nd Floor");
        }

        if (target.value == 12)
        {
            teleportDestination = GameObject.Find("Class 5 2nd Floor");
        }

        if (target.value == 13)
        {
            teleportDestination = GameObject.Find("Class 6 2nd Floor");
        }

        if (target.value == 14)
        {
            teleportDestination = GameObject.Find("Class 7 2nd Floor");
        }

        if (target.value == 15)
        {
            teleportDestination = GameObject.Find("Class 8 2nd Floor");
        }

        if (target.value == 16)
        {
            teleportDestination = GameObject.Find("Class 1 3rd Floor");
        }

        if (target.value == 17)
        {
            teleportDestination = GameObject.Find("Class 2 3rd Floor");
        }

        if (target.value == 18)
        {
            teleportDestination = GameObject.Find("Class 3 3rd Floor");
        }

        if (target.value == 19)
        {
            teleportDestination = GameObject.Find("Class 4 3rd Floor");
        }

        if (target.value == 20)
        {
            teleportDestination = GameObject.Find("Class 5 3rd Floor");
        }

        if (target.value == 21)
        {
            teleportDestination = GameObject.Find("Class 6 3rd Floor");
        }

        if (target.value == 22)
        {
            teleportDestination = GameObject.Find("Class 7 3rd Floor");
        }

        if (target.value == 23)
        {
            teleportDestination = GameObject.Find("Class 8 3rd Floor");
        }

        fadeText.text = teleportDestination.name;
        animation.Play("FadeInOutTeleportScreen");

        StartCoroutine(WaitForAnimation());
    }

    public void ShowPath(Dropdown target)
    {
        if (target.value == 0)
        {
            GameObject classOne = GameObject.Find("Class 1 1st Floor");

            if (PlayerMovement.enteredSecondFloor)
            {
                classOne = GameObject.Find("Collider 2nd Floor");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Collider 3rd Floor");
            }

            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 1 1st Floor";
            Debug.Log(sentText);
            grid2ndFloor.SetActive(false);
            grid3rdFloor.SetActive(false);
        }

        if (target.value == 1)
        {
            GameObject classOne = GameObject.Find("Class 2 1st Floor");

            if (PlayerMovement.enteredSecondFloor)
            {
                classOne = GameObject.Find("Collider 2nd Floor");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Collider 3rd Floor");
            }

            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 2 1st Floor";
            Debug.Log(sentText);
            grid2ndFloor.SetActive(false);
            grid3rdFloor.SetActive(false);
        }

        if (target.value == 2)
        {
            GameObject classOne = GameObject.Find("Class 3 1st Floor");
            if (PlayerMovement.enteredSecondFloor)
            {
                classOne = GameObject.Find("Collider 2nd Floor");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Collider 3rd Floor");
            }

            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 3 1st Floor";
            Debug.Log(sentText);
            grid2ndFloor.SetActive(false);
            grid3rdFloor.SetActive(false);
        }

        if (target.value == 3)
        {
            GameObject classOne = GameObject.Find("Class 4 1st Floor");
            if (PlayerMovement.enteredSecondFloor)
            {
                classOne = GameObject.Find("Collider 2nd Floor");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Collider 3rd Floor");
            }

            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 4 1st Floor";
            Debug.Log(sentText);
            grid2ndFloor.SetActive(false);
            grid3rdFloor.SetActive(false);
        }

        if (target.value == 4)
        {
            GameObject classOne = GameObject.Find("Class 5 1st Floor");
            if (PlayerMovement.enteredSecondFloor)
            {
                classOne = GameObject.Find("Collider 2nd Floor");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Collider 3rd Floor");
            }

            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 5 1st Floor";
            Debug.Log(sentText);
            grid2ndFloor.SetActive(false);
            grid3rdFloor.SetActive(false);
        }

        if (target.value == 5)
        {
            GameObject classOne = GameObject.Find("Class 6 1st Floor");
            if (PlayerMovement.enteredSecondFloor)
            {
                classOne = GameObject.Find("Collider 2nd Floor");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Collider 3rd Floor");
            }

            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 6 1st Floor";
            Debug.Log(sentText);
            grid2ndFloor.SetActive(false);
            grid3rdFloor.SetActive(false);
        }

        if (target.value == 6)
        {
            GameObject classOne = GameObject.Find("Class 7 1st Floor");
            if (PlayerMovement.enteredSecondFloor)
            {
                classOne = GameObject.Find("Collider 2nd Floor");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Collider 3rd Floor");
            }

            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 7 1st Floor";
            Debug.Log(sentText);
            grid2ndFloor.SetActive(false);
            grid3rdFloor.SetActive(false);
        }

        if (target.value == 7)
        {
            GameObject classOne = GameObject.Find("Class 8 1st Floor");
            if (PlayerMovement.enteredSecondFloor)
            {
                classOne = GameObject.Find("Collider 2nd Floor");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Collider 3rd Floor");
            }

            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 8 1st Floor";
            Debug.Log(sentText);
            grid2ndFloor.SetActive(false);
            grid3rdFloor.SetActive(false);
        }

        if (target.value == 8)
        {
            GameObject classOne = GameObject.Find("Class 1 2nd Floor");

            if (PlayerMovement.enteredFirstFloor)
            {
                classOne = GameObject.Find("Collider 1st Floor");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Collider 3rd Floor");
            }

            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 1 2nd Floor";

            grid.SetActive(false);
            grid3rdFloor.SetActive(false);
        }

        if (target.value == 9)
        {
            GameObject classOne = GameObject.Find("Class 2 2nd Floor");

            if (PlayerMovement.enteredFirstFloor)
            {
                classOne = GameObject.Find("Collider 1st Floor");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Collider 3rd Floor");
            }

            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 2 2nd Floor";

            grid.SetActive(false);
            grid3rdFloor.SetActive(false);
        }

        if (target.value == 10)
        {
            GameObject classOne = GameObject.Find("Class 3 2nd Floor");

            if (PlayerMovement.enteredFirstFloor)
            {
                classOne = GameObject.Find("Collider 1st Floor");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Collider 3rd Floor");
            }
            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 3 2nd Floor";

            grid.SetActive(false);
            grid3rdFloor.SetActive(false);
        }

        if (target.value == 11)
        {
            GameObject classOne = GameObject.Find("Class 4 2nd Floor");

            if (PlayerMovement.enteredFirstFloor)
            {
                classOne = GameObject.Find("Collider 1st Floor");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Collider 3rd Floor");
            }
            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 4 2nd Floor";

            grid.SetActive(false);
            grid3rdFloor.SetActive(false);
        }

        if (target.value == 12)
        {
            GameObject classOne = GameObject.Find("Class 5 2nd Floor");

            if (PlayerMovement.enteredFirstFloor)
            {
                classOne = GameObject.Find("Collider 1st Floor");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Collider 3rd Floor");
            }
            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 5 2nd Floor";

            grid.SetActive(false);
            grid3rdFloor.SetActive(false);
        }

        if (target.value == 13)
        {
            GameObject classOne = GameObject.Find("Class 6 2nd Floor");

            if (PlayerMovement.enteredFirstFloor)
            {
                classOne = GameObject.Find("Collider 1st Floor");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Collider 3rd Floor");
            }
            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 6 2nd Floor";

            grid.SetActive(false);
            grid3rdFloor.SetActive(false);
        }

        if (target.value == 14)
        {
            GameObject classOne = GameObject.Find("Class 7 2nd Floor");

            if (PlayerMovement.enteredFirstFloor)
            {
                classOne = GameObject.Find("Collider 1st Floor");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Collider 3rd Floor");
            }
            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 7 2nd Floor";

            grid.SetActive(false);
            grid3rdFloor.SetActive(false);
        }

        if (target.value == 15)
        {
            GameObject classOne = GameObject.Find("Class 8 2nd Floor");

            if (PlayerMovement.enteredFirstFloor)
            {
                classOne = GameObject.Find("Collider 1st Floor");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Collider 3rd Floor");
            }
            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 8 2nd Floor";

            grid.SetActive(false);
            grid3rdFloor.SetActive(false);
        }

        if (target.value == 16)
        {
            GameObject classOne = GameObject.Find("Class 1 3rd Floor");

            if (PlayerMovement.enteredFirstFloor)
            {
                classOne = GameObject.Find("Collider 1st Floor");
            }
            if (PlayerMovement.enteredSecondFloor)
            {
                classOne = GameObject.Find("Collider 2nd Floor (1)");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Class 1 3rd Floor");
            }
            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 1 3rd Floor";

            grid.SetActive(false);
            grid2ndFloor.SetActive(false);
        }

        if (target.value == 17)
        {
            GameObject classOne = GameObject.Find("Class 2 3rd Floor");

            if (PlayerMovement.enteredFirstFloor)
            {
                classOne = GameObject.Find("Collider 1st Floor");
            }
            if (PlayerMovement.enteredSecondFloor)
            {
                classOne = GameObject.Find("Collider 2nd Floor (1)");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Class 2 3rd Floor");
            }
            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 2 3rd Floor";

            grid.SetActive(false);
            grid2ndFloor.SetActive(false);
        }

        if (target.value == 18)
        {
            GameObject classOne = GameObject.Find("Class 3 3rd Floor");

            if (PlayerMovement.enteredFirstFloor)
            {
                classOne = GameObject.Find("Collider 1st Floor");
            }
            if (PlayerMovement.enteredSecondFloor)
            {
                classOne = GameObject.Find("Collider 2nd Floor (1)");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Class 3 3rd Floor");
            }
            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 3 3rd Floor";

            grid.SetActive(false);
            grid2ndFloor.SetActive(false);
        }

        if (target.value == 19)
        {
            GameObject classOne = GameObject.Find("Class 4 3rd Floor");

            if (PlayerMovement.enteredFirstFloor)
            {
                classOne = GameObject.Find("Collider 1st Floor");
            }
            if (PlayerMovement.enteredSecondFloor)
            {
                classOne = GameObject.Find("Collider 2nd Floor (1)");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Class 4 3rd Floor");
            }
            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 4 3rd Floor";

            grid.SetActive(false);
            grid2ndFloor.SetActive(false);
        }

        if (target.value == 20)
        {
            GameObject classOne = GameObject.Find("Class 5 3rd Floor");

            if (PlayerMovement.enteredFirstFloor)
            {
                classOne = GameObject.Find("Collider 1st Floor");
            }
            if (PlayerMovement.enteredSecondFloor)
            {
                classOne = GameObject.Find("Collider 2nd Floor (1)");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Class 5 3rd Floor");
            }
            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 5 3rd Floor";

            grid.SetActive(false);
            grid2ndFloor.SetActive(false);
        }

        if (target.value == 21)
        {
            GameObject classOne = GameObject.Find("Class 6 3rd Floor");

            if (PlayerMovement.enteredFirstFloor)
            {
                classOne = GameObject.Find("Collider 1st Floor");
            }
            if (PlayerMovement.enteredSecondFloor)
            {
                classOne = GameObject.Find("Collider 2nd Floor (1)");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Class 6 3rd Floor");
            }
            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 6 3rd Floor";

            grid.SetActive(false);
            grid2ndFloor.SetActive(false);
        }

        if (target.value == 22)
        {
            GameObject classOne = GameObject.Find("Class 7 3rd Floor");

            if (PlayerMovement.enteredFirstFloor)
            {
                classOne = GameObject.Find("Collider 1st Floor");
            }
            if (PlayerMovement.enteredSecondFloor)
            {
                classOne = GameObject.Find("Collider 2nd Floor (1)");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Class 7 3rd Floor");
            }
            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 7 3rd Floor";

            grid.SetActive(false);
            grid2ndFloor.SetActive(false);
        }

        if (target.value == 23)
        {
            GameObject classOne = GameObject.Find("Class 8 3rd Floor");

            if (PlayerMovement.enteredFirstFloor)
            {
                classOne = GameObject.Find("Collider 1st Floor");
            }
            if (PlayerMovement.enteredSecondFloor)
            {
                classOne = GameObject.Find("Collider 2nd Floor (1)");
            }
            if (PlayerMovement.enteredThirdFloor)
            {
                classOne = GameObject.Find("Class 8 3rd Floor");
            }
            Pathfinding.target = classOne.GetComponent<Transform>();
            sentText = "Class 8 3rd Floor";

            grid.SetActive(false);
            grid2ndFloor.SetActive(false);
        }
    }

    IEnumerator WaitForAnimation()
    {
        yield return new WaitForSeconds(1);
        cc = player.GetComponent<CharacterController>();

        cc.enabled = false;
        cc.transform.position = teleportDestination.transform.position;
        cc.enabled = true;

        player.transform.position = teleportDestination.transform.position;
        uiPanel.SetActive(false);
        animation.Stop("FadeInOutTeleportScreen");
    }
}

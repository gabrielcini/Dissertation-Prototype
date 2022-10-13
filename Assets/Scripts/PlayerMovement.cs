using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;

    public static bool enteredFirstFloor, enteredSecondFloor = false, enteredThirdFloor = false, collidedSocle = false, collidedSocleOne = false, collidedSocleTwo = false, collidedSocleThree = false, collidedSocleFour = false, collidedSocleFive = false;

    Vector3 velocity;

    GameObject grid, grid2ndFloor, grid3rdFloor;

    string floorDirection;

    void Start()
    {
        enteredFirstFloor = true;
        enteredSecondFloor = false;
        enteredThirdFloor = false;

        //grid = GameObject.Find("A*");
        //grid2ndFloor = GameObject.Find("A* 2nd Floor");
        //grid3rdFloor = GameObject.Find("A* 3rd Floor");
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        /*if (grid != null)
        {
            if (enteredFirstFloor)
            {
                grid.SetActive(true);
                grid2ndFloor.SetActive(false);
                grid3rdFloor.SetActive(false);
            }

            if (enteredSecondFloor)
            {
                grid.SetActive(false);
                grid2ndFloor.SetActive(true);
                grid3rdFloor.SetActive(false);
            }

            if (enteredThirdFloor)
            {
                grid.SetActive(false);
                grid2ndFloor.SetActive(false);
                grid3rdFloor.SetActive(true);
            }
        }*/
    }

    /*void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "1st Floor")
        {
            Debug.Log("Entered First Floor");
            GameObject classNumber = GameObject.Find("");

            if (ButtonScript.sentText != null)
            {
                if (ButtonScript.sentText.Contains("2nd Floor") || ButtonScript.sentText.Contains("3rd Floor"))
                {
                    floorDirection = "Collider 1st Floor";
                    classNumber = GameObject.Find(floorDirection);
                    Pathfinding.target = classNumber.GetComponent<Transform>();
                }

                if (ButtonScript.sentText.Contains("1st Floor"))
                {
                    classNumber = GameObject.Find(ButtonScript.sentText);
                    Pathfinding.target = classNumber.GetComponent<Transform>();
                }
            }

            enteredFirstFloor = true;
            enteredSecondFloor = false;
            enteredThirdFloor = false;
        }

        if (collision.gameObject.tag == "2nd Floor")
        {
            Debug.Log("Entered Second Floor");

            GameObject classNumber = GameObject.Find(ButtonScript.sentText);
            Pathfinding.target = classNumber.GetComponent<Transform>();

            if (ButtonScript.sentText.Contains("1st Floor"))
            {
                floorDirection = "Collider 2nd Floor";
                classNumber = GameObject.Find(floorDirection);
                Pathfinding.target = classNumber.GetComponent<Transform>();
            }
            if (ButtonScript.sentText.Contains("3rd Floor"))
            {
                floorDirection = "Collider 2nd Floor (1)";
                classNumber = GameObject.Find(floorDirection);
                Pathfinding.target = classNumber.GetComponent<Transform>();
            }

            enteredFirstFloor = false;
            enteredSecondFloor = true;
            enteredThirdFloor = false;
        }

        if (collision.gameObject.tag == "3rd Floor")
        {
            Debug.Log("Entered Third Floor");

            GameObject classNumber = GameObject.Find(ButtonScript.sentText);
            Pathfinding.target = classNumber.GetComponent<Transform>();

            if (ButtonScript.sentText.Contains("2nd Floor") || ButtonScript.sentText.Contains("1st Floor"))
            {
                floorDirection = "Collider 3rd Floor";
                classNumber = GameObject.Find(floorDirection);
                Pathfinding.target = classNumber.GetComponent<Transform>();
            }

            enteredFirstFloor = false;
            enteredSecondFloor = false;
            enteredThirdFloor = true;
        }


        if (collision.gameObject.name == "socle")
        {
            collidedSocle = true;
            collidedSocleOne = false;
            collidedSocleTwo = false;
            collidedSocleThree = false;
            collidedSocleFour = false;
            collidedSocleFive = false;
        }

        else if (collision.gameObject.name == "socle.001")
        {
            collidedSocle = false;
            collidedSocleOne = true;
            collidedSocleTwo = false;
            collidedSocleThree = false;
            collidedSocleFour = false;
            collidedSocleFive = false;
        }

        else if (collision.gameObject.name == "socle.002")
        {
            collidedSocle = false;
            collidedSocleOne = false;
            collidedSocleTwo = true;
            collidedSocleThree = false;
            collidedSocleFour = false;
            collidedSocleFive = false;
        }

        else if (collision.gameObject.name == "socle.003")
        {
            collidedSocle = false;
            collidedSocleOne = false;
            collidedSocleTwo = false;
            collidedSocleThree = true;
            collidedSocleFour = false;
            collidedSocleFive = false;
        }

        else if (collision.gameObject.name == "socle.004")
        {
            collidedSocle = false;
            collidedSocleOne = false;
            collidedSocleTwo = false;
            collidedSocleThree = false;
            collidedSocleFour = true;
            collidedSocleFive = false;
        }

        else if (collision.gameObject.name == "socle.005")
        {
            collidedSocle = false;
            collidedSocleOne = false;
            collidedSocleTwo = false;
            collidedSocleThree = false;
            collidedSocleFour = false;
            collidedSocleFive = true;
        }
        else
        {
            collidedSocle = false;
            collidedSocleOne = false;
            collidedSocleTwo = false;
            collidedSocleThree = false;
            collidedSocleFour = false;
            collidedSocleFive = false;
        }
    }*/

}

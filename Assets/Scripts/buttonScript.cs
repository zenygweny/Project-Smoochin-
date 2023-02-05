using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script controls the buttons on the screen

public class buttonScript : MonoBehaviour
{

    //Universal Variables

    storageScript sScript;

    public GameObject startingTown;
    public GameObject Club;
    public GameObject Conversation;

    //Portrait Gal Game Objects

    public GameObject Gal1;
    public GameObject Gal2;

    //Conversation Game Objects

    public GameObject tapBox;

    // Start is called before the first frame update
    void Start()
    {
        
        GameObject Storage = GameObject.Find("Storage");
        sScript = Storage.GetComponent<storageScript>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            //The code that allows buttons to be pressed based upon where the mouse is clicked and if the object has a collider and a
            //specific name attached to it.

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit != null && hit.collider != null)
            {

                //Title Screen Buttons

                if (hit.collider.gameObject.name == "Start Button")
                {

                    GameObject tScreen = GameObject.Find("Title Screen");
                    Destroy(tScreen);
                    Instantiate(startingTown, new Vector3(0,0,0), transform.rotation);

                }

                if (hit.collider.gameObject.name == "Quit Button")
                {

                    Application.Quit();

                }

                //Overworld Buttons

                if (hit.collider.gameObject.name == "Club")
                {

                    GameObject Town = GameObject.Find("Town(Clone)");
                    sScript.Location = "Club";
                    //Debug.Log(sScript.Location); //Example Print
                    Destroy(Town);
                    Instantiate(Club, new Vector3(0,0,0), transform.rotation);

                }

                //Club Buttons

                if (hit.collider.gameObject.name == "Exit Button")
                {

                    GameObject Club = GameObject.Find("Club(Clone)");
                    Destroy(Club);
                    Instantiate(startingTown, new Vector3(0,0,0), transform.rotation);

                }

                if (hit.collider.gameObject.name == "Gal 1 Portrait")
                {
                    
                    Instantiate(Conversation, new Vector3(0,0,-1.1f), transform.rotation);
                    Instantiate(Gal1, new Vector3(0,-.7f,-1), transform.rotation);
                    GameObject Convo = GameObject.Find("Conversations(Clone)");
                    GameObject gal1 = GameObject.Find("Gal 1(Clone)");
                    gal1.transform.parent = Convo.transform;
                    GameObject eButton = GameObject.Find("Exit Button");
                    eButton.transform.position += new Vector3(10,0,0);
                    GameObject gal1P = GameObject.Find("Gal 1 Portrait");
                    gal1P.transform.position += new Vector3(10,0,0);
                    sScript.galName = "Gal 1";

                }

                //Conversation Buttons

                if (hit.collider.gameObject.name == "Leave Button")
                {

                    GameObject Convo = GameObject.Find("Conversations(Clone)");
                    Destroy(Convo);
                    GameObject eButton = GameObject.Find("Exit Button");
                    eButton.transform.position += new Vector3(-10,0,0);

                    if(sScript.galName == "Gal 1"){

                        GameObject gal1P = GameObject.Find("Gal 1 Portrait");
                        gal1P.transform.position += new Vector3(-10,0,0);
                        sScript.galName = "";

                    }

                }

            }

        }

    }

}

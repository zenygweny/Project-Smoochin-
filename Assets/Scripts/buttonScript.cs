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
    public GameObject Gym;
    public GameObject Conversation;

    //Portrait Gal Game Objects

    public GameObject Gal1;
    public GameObject Gal2;

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

                if (hit.collider.gameObject.name == "Gym")
                {

                    GameObject Town = GameObject.Find("Town(Clone)");
                    sScript.Location = "Gym";
                    Destroy(Town);
                    Instantiate(Gym, new Vector3(0,0,0), transform.rotation);

                }

                //Club Buttons

                if (hit.collider.gameObject.name == "Exit Button")
                {

                    if(sScript.Location == "Club"){

                        GameObject Club = GameObject.Find("Club(Clone)");
                        Destroy(Club);
                        Instantiate(startingTown, new Vector3(0,0,0), transform.rotation);

                    }

                    if(sScript.Location == "Gym"){

                        GameObject Gym = GameObject.Find("Gym(Clone)");
                        Destroy(Gym);
                        Instantiate(startingTown, new Vector3(0,0,0), transform.rotation);

                    }

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
                    GameObject tBoxes = GameObject.Find("Text Box");
                    tBoxes.transform.position += new Vector3(-20,0,0);
                    GameObject tapBox = GameObject.Find("Tap Box");
                    tapBox.transform.position += new Vector3(-20,0,0);
                    GameObject choice1 = GameObject.Find("Choice 1");
                    choice1.transform.position += new Vector3(-20,0,0);
                    GameObject choice2 = GameObject.Find("Choice 2");
                    choice2.transform.position += new Vector3(-20,0,0);
                    GameObject choice3 = GameObject.Find("Choice 3");
                    choice3.transform.position += new Vector3(-20,0,0);
                    sScript.galName = "Gal 1";

                }

                if (hit.collider.gameObject.name == "Gal 2 Portrait")
                {
                    
                    Instantiate(Conversation, new Vector3(0,0,-1.1f), transform.rotation);
                    Instantiate(Gal2, new Vector3(0,-.7f,-1), transform.rotation);
                    GameObject Convo = GameObject.Find("Conversations(Clone)");
                    GameObject gal2 = GameObject.Find("Gal 2(Clone)");
                    gal2.transform.parent = Convo.transform;
                    GameObject eButton = GameObject.Find("Exit Button");
                    eButton.transform.position += new Vector3(10,0,0);
                    GameObject gal2P = GameObject.Find("Gal 2 Portrait");
                    gal2P.transform.position += new Vector3(10,0,0);
                    GameObject tBoxes = GameObject.Find("Text Box");
                    tBoxes.transform.position += new Vector3(-20,0,0);
                    GameObject tapBox = GameObject.Find("Tap Box");
                    tapBox.transform.position += new Vector3(-20,0,0);
                    GameObject choice1 = GameObject.Find("Choice 1");
                    choice1.transform.position += new Vector3(-20,0,0);
                    GameObject choice2 = GameObject.Find("Choice 2");
                    choice2.transform.position += new Vector3(-20,0,0);
                    GameObject choice3 = GameObject.Find("Choice 3");
                    choice3.transform.position += new Vector3(-20,0,0);
                    sScript.galName = "Gal 2";

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

                    if(sScript.galName == "Gal 2"){

                        GameObject gal2P = GameObject.Find("Gal 2 Portrait");
                        gal2P.transform.position += new Vector3(-10,0,0);
                        sScript.galName = "";

                    }

                }

                if (hit.collider.gameObject.name == "Talk Button")
                {

                    GameObject tButton = GameObject.Find("Talk Button");
                    tButton.transform.position += new Vector3(-20,0,0);
                    GameObject lButton = GameObject.Find("Leave Button");
                    lButton.transform.position += new Vector3(10,0,0);
                    GameObject tBoxes = GameObject.Find("Text Box");
                    tBoxes.transform.position += new Vector3(20,0,0);
                    GameObject tapBox = GameObject.Find("Tap Box");
                    tapBox.transform.position += new Vector3(20,0,0);
                    Animator textAnim = tBoxes.GetComponent<Animator>();

                    if(sScript.galName == "Gal 1"){

                        textAnim.Play(sScript.g1Convo[sScript.g1ConvoMark]);

                    }
                    
                }

                if (hit.collider.gameObject.name == "Tap Box")
                {

                    if(sScript.galName == "Gal 1"){

                        sScript.g1ConvoMark++;

                        if(sScript.g1Convo[sScript.g1ConvoMark] == "Break"){

                            sScript.g1ConvoMark++;
                            GameObject tapBox = GameObject.Find("Tap Box");
                            tapBox.transform.position += new Vector3(-20,0,0);
                            GameObject choice1 = GameObject.Find("Choice 1");
                            Animator choice1Anim = choice1.GetComponent<Animator>();
                            choice1Anim.Play(sScript.g1Choice1[sScript.g1ChoiceMark]);
                            choice1.transform.position += new Vector3(20,0,0);
                            GameObject choice2 = GameObject.Find("Choice 2");
                            Animator choice2Anim = choice2.GetComponent<Animator>();
                            choice2Anim.Play(sScript.g1Choice2[sScript.g1ChoiceMark]);
                            choice2.transform.position += new Vector3(20,0,0);
                            GameObject choice3 = GameObject.Find("Choice 3");
                            Animator choice3Anim = choice3.GetComponent<Animator>();
                            choice3Anim.Play(sScript.g1Choice3[sScript.g1ChoiceMark]);
                            choice3.transform.position += new Vector3(20,0,0);

                        }

                        if(sScript.g1Convo[sScript.g1ConvoMark] == "End"){

                            
                            GameObject tBoxes = GameObject.Find("Text Box");
                            tBoxes.transform.position += new Vector3(-20,0,0);
                            GameObject tButton = GameObject.Find("Talk Button");
                            tButton.transform.position += new Vector3(20,0,0);
                            GameObject tapBox = GameObject.Find("Tap Box");
                            tapBox.transform.position += new Vector3(20,0,0);
                            GameObject lButton = GameObject.Find("Leave Button");
                            lButton.transform.position += new Vector3(-10,0,0);

                            while(sScript.g1Convo[sScript.g1ConvoMark] != "Stop"){

                                sScript.g1ConvoMark++;

                            }

                        }

                    }

                }

                if (hit.collider.gameObject.name == "Choice 1")
                {

                    if(sScript.galName == "Gal 1"){

                        sScript.g1ChoiceMark++;

                        if(sScript.g1Choice1[sScript.g1ChoiceMark] == "Break"){

                            sScript.g1ChoiceMark++;
                            GameObject choice1 = GameObject.Find("Choice 1");
                            choice1.transform.position += new Vector3(-20,0,0);
                            GameObject choice2 = GameObject.Find("Choice 2");
                            choice2.transform.position += new Vector3(-20,0,0);
                            GameObject choice3 = GameObject.Find("Choice 3");
                            choice3.transform.position += new Vector3(-20,0,0);
                            GameObject tBoxes = GameObject.Find("Text Box");
                            GameObject tapBox = GameObject.Find("Tap Box");
                            tapBox.transform.position += new Vector3(20,0,0);
                            Animator textAnim = tBoxes.GetComponent<Animator>();
                            textAnim.Play(sScript.g1Convo[sScript.g1ConvoMark]);

                        }

                    }

                }

                if (hit.collider.gameObject.name == "Choice 2")
                {

                    if(sScript.galName == "Gal 1"){

                        sScript.g1ChoiceMark++;

                        if(sScript.g1Choice2[sScript.g1ChoiceMark] == "Break"){

                            sScript.g1ChoiceMark++;
                            sScript.g1ConvoMark += 2;
                            GameObject choice1 = GameObject.Find("Choice 1");
                            choice1.transform.position += new Vector3(-20,0,0);
                            GameObject choice2 = GameObject.Find("Choice 2");
                            choice2.transform.position += new Vector3(-20,0,0);
                            GameObject choice3 = GameObject.Find("Choice 3");
                            choice3.transform.position += new Vector3(-20,0,0);
                            GameObject tBoxes = GameObject.Find("Text Box");
                            GameObject tapBox = GameObject.Find("Tap Box");
                            tapBox.transform.position += new Vector3(20,0,0);
                            Animator textAnim = tBoxes.GetComponent<Animator>();
                            textAnim.Play(sScript.g1Convo[sScript.g1ConvoMark]);

                        }

                    }

                }

                if (hit.collider.gameObject.name == "Choice 3")
                {

                    if(sScript.galName == "Gal 1"){

                        sScript.g1ChoiceMark++;

                        if(sScript.g1Choice2[sScript.g1ChoiceMark] == "Break"){

                            sScript.g1ChoiceMark++;
                            sScript.g1ConvoMark += 4;
                            GameObject choice1 = GameObject.Find("Choice 1");
                            choice1.transform.position += new Vector3(-20,0,0);
                            GameObject choice2 = GameObject.Find("Choice 2");
                            choice2.transform.position += new Vector3(-20,0,0);
                            GameObject choice3 = GameObject.Find("Choice 3");
                            choice3.transform.position += new Vector3(-20,0,0);
                            GameObject tBoxes = GameObject.Find("Text Box");
                            GameObject tapBox = GameObject.Find("Tap Box");
                            tapBox.transform.position += new Vector3(20,0,0);
                            Animator textAnim = tBoxes.GetComponent<Animator>();
                            textAnim.Play(sScript.g1Convo[sScript.g1ConvoMark]);

                        }

                    }

                }

            }

        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storageScript : MonoBehaviour
{

    public string Location = "";
    public string galName = "";

    //Conversation Variables

    public int g1ConvoMark = 0;
    public int g1ChoiceMark = 0;
    public int g1ChoiceMark2 = 1;

    public string[] g1Convo;
    public string[] g1Choice1;
    public string[] g1Choice2;
    public string[] g1Choice3;

    // Start is called before the first frame update
    void Start()
    {

        this.g1Convo = new string[99];
        this.g1Choice1 = new string[99];
        this.g1Choice2 = new string[99];
        this.g1Choice3 = new string[99];
        this.convoSet();
        this.choiceSet();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void choiceSet(){

        g1Choice1[0] = "G1 Choice 1-"+this.g1ChoiceMark2+"";
        g1Choice1[1] = "Break";
        g1Choice2[0] = "G1 Choice 2-"+this.g1ChoiceMark2+"";
        g1Choice2[1] = "Break";
        g1Choice3[0] = "G1 Choice 3-"+this.g1ChoiceMark2+"";
        g1Choice3[1] = "Break";

    }

    public void convoSet(){

        g1Convo[0] = "G1 Intro 1";
        g1Convo[1] = "Break";
        g1Convo[2] = "G1 Intro 2";
        g1Convo[3] = "End";
        g1Convo[4] = "G1 Intro 3";
        g1Convo[5] = "End";
        g1Convo[6] = "G1 Intro 4";
        g1Convo[7] = "End";
        g1Convo[8] = "Stop";

    }
    
}

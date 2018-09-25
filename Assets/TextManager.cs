using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {

    public Text myText;
    private int myState = 0;

    public Sprite myFrog, myEagle, myPossum;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && myState == 0)
        {
            myText.text = "Hello! Come to Fox Island to see our most amazing attractions!!";
            myState++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && myState == 1)
        {
            myText.text = "We've got amazing mountains to climb!";
            myState++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && myState == 2)
        {
            myText.text = "And adventurous caves to delve deep into!";
            myState++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && myState == 3)
        {
            myText.text = "Just make sure not to get eaten by any of the locals!";
            myState++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && myState == 4)
        {
            myText.text = "Just kidding! It's a great time here on Fox Island! Come visit us today!!";
        }

    }
    }

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class displayUI : MonoBehaviour
{

    public string myString;
    public Text myText;
    public float fadeTime;
    public bool displayInfo;

    // Use this for initialization
    void Start()
    {

        myText = GameObject.Find("Text").GetComponent<Text>();
        myText.color = Color.clear;
        //Screen.showCursor = false;
        //Screen.lockCursor = true;
    }

    // Update is called once per frame
    void Update()
    {

        FadeText();

        /*if (Input.GetKeyDown (KeyCode.Escape)) 
         
                {
                        Screen.lockCursor = false;
                         
                }
                */


    }

    void OnMouseOver()
    {
        displayInfo = true;

    }
    void OnMouseExit()

    {
        displayInfo = false;

    }
    public class LookAtTarget : MonoBehaviour
    {
        public Transform target;


        void Update()
        {
            if (target != null)
            {
                transform.LookAt(target);
            }
        }

    }

    void FadeText()

    {


        if (displayInfo)
        {
            myText.text = myString;
            myText.color = Color.Lerp(myText.color, Color.red, fadeTime * Time.deltaTime);
        }

        else
        {

            myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
        }




    }



}
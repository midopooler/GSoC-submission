using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class Vibcode : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject wikipedia;
    public GameObject AR;
    // Start is called before the first frame update
    void Start()
    {



        wikipedia = GameObject.Find("wikipedia");
        wikipedia.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        AR = GameObject.Find("AR");
        AR.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("pressed...........");

        if (vb.VirtualButtonName == "wikipedia")
        {
            Application.OpenURL("https://en.wikipedia.org/wiki/Taj_Mahal");
            Debug.Log("WIKIPEDIa TRIGERRED");
        }
        else if (vb.VirtualButtonName == "AR")
        {
            SceneManager.LoadScene("AugmentingonPlane");
            Debug.Log("New AR scene triggered");
        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }
    // Update is called once per frame
    void Update()
    {


    }
}
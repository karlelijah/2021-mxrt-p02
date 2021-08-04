using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class buttonScript : MonoBehaviour
{
    public GameObject PlusButton;
    public GameObject MinusButton;
    public GameObject ResetButton;
    public GameObject target;

    Vector3 mInitialSize;
    Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        mInitialSize = new Vector3(1.8f, 1.8f, 1.8f);
        scaleChange = new Vector3(0.1f, 0.1f, 0.1f);
        PlusButton = GameObject.Find("PlusButton");
        MinusButton = GameObject.Find("MinusButton");
        ResetButton = GameObject.Find("ResetButton");
        PlusButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(IncreaseSizePressed);
        PlusButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(IncreaseSizeReleased);
        MinusButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(DecreaseSizePressed);
        MinusButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(DecreaseSizeReleased);
        ResetButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(ResetSizePressed);
        ResetButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(ResetSizeReleased);
    }

    public void IncreaseSizePressed(VirtualButtonBehaviour vb)
    {
        target.transform.localScale += scaleChange;
        Debug.Log("IncreaseSizeButton Pressed.");
    }
    public void IncreaseSizeReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("IncreaseSizeButton Released.");
    }
    public void DecreaseSizePressed(VirtualButtonBehaviour vb)
    {
        target.transform.localScale -= scaleChange;
        Debug.Log("DecreaseSizeButton Pressed.");
    }
    public void DecreaseSizeReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("DecreaseSizeButton Released.");
    }
    public void ResetSizePressed(VirtualButtonBehaviour vb)
    {
        target.transform.localScale = mInitialSize;
        Debug.Log("ResetSizeButton Pressed.");
    }
    public void ResetSizeReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("ResetSizeButton Released.");
    }
}

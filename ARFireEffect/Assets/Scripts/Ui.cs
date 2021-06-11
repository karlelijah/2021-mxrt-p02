using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui : MonoBehaviour
{
    public Button mPlusButton, mMinusButton, mResetButton;
    public Button mDnaButton, mPlaneButton;

    private GameObject target;
    public GameObject dna;
    public GameObject plane;

    private Vector3 mInitialSize;
    private Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(0.1f, 0.1f, 0.1f);
        mPlusButton.onClick.AddListener(modelIncrease);
        mMinusButton.onClick.AddListener(modelDecrease);
        mResetButton.onClick.AddListener(modelReset);
        mDnaButton.onClick.AddListener(mDna);
        mPlaneButton.onClick.AddListener(mPlane);
    }
    
    void modelIncrease()
    {
        target.transform.localScale += scaleChange;
    }

    void modelDecrease()
    {
        target.transform.localScale -= scaleChange;
    }

    void modelReset()
    {
        target.transform.localScale = mInitialSize;
    }
    void mDna()
    {
        target = dna;
        Debug.Log("Target GameObject is now " + target);
        mInitialSize = new Vector3(1.8f, 1.8f, 1.8f);
    }

    void mPlane()
    {
        target = plane;
        Debug.Log("Target GameObject is now " + target);
        mInitialSize = new Vector3(1f, 1f, 1.0f);
    }
}

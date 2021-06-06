using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public GameObject target;
    private Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        Upscale();
        Downscale();
        scaleChange = new Vector3(0.1f, 0.1f, 0.1f);
    }
    void Upscale()
    {
        target.transform.localScale += scaleChange;
    }

    // Update is called once per frame
    void Downscale()
    {
        target.transform.localScale -= scaleChange;
    }
    private void Update()
    {
        Upscale();
        Downscale();
    }
}

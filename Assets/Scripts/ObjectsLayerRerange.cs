using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class ObjectsLayerRerange : MonoBehaviour
{
   
    public Renderer[] allRenders;
    Camera CenterCam,peripheralCam;


    // Start is called before the first frame update
    void Start()
    {
        allRenders = FindObjectsOfType<Renderer>();


       
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var r in allRenders) {

            bool camCenter = RendererExtensions.IsVisibleFrom(r , CenterCam);
            bool camPer = RendererExtensions.IsVisibleFrom(r, peripheralCam);





        }

     



    }


 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class ObjectsLayerRerange : MonoBehaviour
{
   
    public Renderer[] allRenders;
   public Camera CenterCam,peripheralCam;


    // Start is called before the first frame update
    void Start()
    {
        allRenders = FindObjectsOfType<Renderer>();


       
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var r in allRenders) {


            if(r.gameObject.tag=="NotiObject"){

                bool camCenter = RendererExtensions.IsVisibleFrom(r , CenterCam);
          

                if(camCenter){

                    r.gameObject.layer=0;

                }else{


                      r.gameObject.layer=6;



                }







            }
            





        }

     



    }


 
}

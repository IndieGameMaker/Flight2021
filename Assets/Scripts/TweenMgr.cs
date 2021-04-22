using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenMgr : MonoBehaviour
{
    public GameObject ufo1, ufo2, ufo3;

    void Start()
    {
        iTween.MoveTo(ufo1, iTween.Hash("y",100.0f
                                       ,"time",3.0f
                                       ,"easetype",iTween.EaseType.easeOutElastic));

        Hashtable ht2 = new Hashtable();
        ht2.Add("y", 100.0f);
        ht2.Add("delay", 3.0f);
        ht2.Add("time", 1.0f);
        ht2.Add("easetype", iTween.EaseType.easeOutBounce);

        iTween.MoveBy(ufo2, ht2);

        Hashtable ht3 = new Hashtable();
        ht3.Add("y", 250.0f);
        ht3.Add("delay", 4.0f);
        ht3.Add("time", 1.5f);
        ht3.Add("easetype", iTween.EaseType.easeOutElastic);
        iTween.MoveFrom(ufo3, ht3);
    }

}

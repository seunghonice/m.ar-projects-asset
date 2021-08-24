using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyMaterialForIOS : MonoBehaviour
{
    public Material[] materialsForIOS;

    // Start is called before the first frame update
    void Start()
    {
#if UNITY_IOS
        GetComponent<MeshRenderer>().materials = materialsForIOS;    
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

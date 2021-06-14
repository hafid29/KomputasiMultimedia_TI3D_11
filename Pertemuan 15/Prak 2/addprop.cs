using System.Collections.Generic;
using UnityEngine;

public class addprop : MonoBehaviour
{
    public GameObject prop;
    public Transform targetBone;
    public Vector3 positionOffset;
    public Vector3 rotationOffset;
    public bool destroyTrigger = true;

    // Start is called before the first frame update
    void OnTriggerEnter ( Collider collision )
    {
        if (targetBone.IsChildOf(collision.transform)){
            bool checkProp = false;
            foreach(Transform child in targetBone){
                checkProp = true;
            }

            if(!checkProp){
                GameObject newprop;
                newprop = Instantiate(prop, targetBone.position, targetBone.rotation) as GameObject;
                newprop.name = prop.name;
                newprop.transform.parent = targetBone;
                newprop.transform.localPosition += positionOffset;
                newprop.transform.localEulerAngles += rotationOffset;
                if(destroyTrigger)
                Destroy(gameObject);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpScript : MonoBehaviour
{
    public GameObject Alert;
    public bool isActive = false;
    public Transform Target;
    public Transform alertTransform;
    // Start is called before the first frame update
    void Start()
    {
        Alert.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        alertTransform.LookAt(Target.transform);   
    }
}

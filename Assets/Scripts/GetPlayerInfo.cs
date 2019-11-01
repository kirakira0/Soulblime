using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GetPlayerInfo : MonoBehaviour
{
    public InputField inputField; 
    // Start is called before the first frame update
    void Start()
    {
        //inputField = this.GetComponent<InputField>(); 
        inputField.characterLimit = 12; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

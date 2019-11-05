using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
<<<<<<< HEAD

public class GetPlayerInfo : MonoBehaviour
{
    public InputField inputField; 
    // Start is called before the first frame update
    void Start()
    {
        //inputField = this.GetComponent<InputField>(); 
        inputField.characterLimit = 12; 
=======
using Fungus; 
using UnityEngine.SceneManagement; 

public class GetPlayerInfo : MonoBehaviour
{
    public Button begin; 
    public InputField inputField;
    public Dropdown dropdown;  
    private string getName; 
    public string playerName;

    public string playerGender; 
    public Fungus.Flowchart flowchart;

    
    // Start is called before the first frame update
    void Start()
    {
        inputField.characterLimit = 12;
        //inputField.CharacterValidation.name; 
        begin.onClick.AddListener(TaskOnClick); 
>>>>>>> origin/master
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        
    }
=======
        Debug.Log(flowchart.GetStringVariable("playerName")); 
        Debug.Log(flowchart.GetStringVariable("playerGender")); 
    }
    
    void TaskOnClick(){
		if (dropdown.value == 0) {
            playerGender = "nonbinary";
        }
        else if (dropdown.value == 1) {
            playerGender = "female"; 
        }
        else {
            playerGender = "male"; 
        }
        
        if (inputField.text != "") { //make sure it's not empty  
            name = flowchart.GetStringVariable("playerName");
            flowchart.SetStringVariable("playerName", inputField.text);
            //gender = flowchart.GetStringVariable("playerGender");
            //flowchart.SetStringVariable("playerGender", playerGender);
 
            flowchart.ExecuteBlock("Wake Up");
            Destroy(transform.gameObject.GetComponentInParent<Canvas>().gameObject); 
        }
	}
>>>>>>> origin/master
}

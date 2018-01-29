using UnityEngine;
using System.Collections;
using System.Dynamic;
using Newtonsoft.Json;

public class NewBehaviourScript : MonoBehaviour {

    // Use this for initialization
    void Start () {
        string jsontext = "{'hello':'world'}";
        var jsonobj = JsonConvert.DeserializeObject<dynamic>(jsontext);
        string v = jsonobj.hello;
        Debug.Log("hello value is " + v);
        
    }
    
    // Update is called once per frame
    void Update () {
    
    }
}

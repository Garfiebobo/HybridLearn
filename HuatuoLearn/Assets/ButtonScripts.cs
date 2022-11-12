using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button Gbtn = gameObject.GetComponent<Button>();
        Gbtn.onClick.AddListener(() => Debug.Log("123"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


partial class MonoBehaviour: Behaviour
{
    public void AvalonHello()
    {
        Debug.Log("hello avalon");
    }
}

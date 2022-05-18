using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Incapualization : MonoBehaviour
{
    private string Text;
    public string m_Text
    {
        get { return Text; }  // Encapsulation
        set {
            if (value == "poop")
            {

                Debug.LogError("You can't write poop!");
            }
            else
            {
                Text = value; // original setter now in if/else statement
            }
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        Text = gameObject.GetComponent<Text>().text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

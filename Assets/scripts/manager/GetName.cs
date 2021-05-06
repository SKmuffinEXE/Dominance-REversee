using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetName : MonoBehaviour
{
    public TMP_Text UpperName;
    public TMP_InputField mcName;
    // Start is called before the first frame update
    void Start()
    {
        
        if (mcName != null)
        {
            mcName.text = "Ashley";
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        UpperName.text = mcName.text;        
    }

    public void selectInput()
    {
        mcName.Select();
    }
}

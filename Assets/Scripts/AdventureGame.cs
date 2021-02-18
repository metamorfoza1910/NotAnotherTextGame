using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent;

    [SerializeField] public string GameText;



    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = GameText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    public string GameText;

    State state;



    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = state.GetStateStory();
    }
}

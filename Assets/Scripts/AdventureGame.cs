using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
  [SerializeField] Text textComponent;
  [SerializeField] State StartingState;



  State state;



  // Start is called before the first frame update
  void Start()
  {
    state = StartingState;
    textComponent.text = state.GetStateStory();

    textComponent.fontStyle = (FontStyle.Bold);
    textComponent.alignment = TextAnchor.MiddleCenter;
    textComponent.fontSize = 40;
  }

  // Update is called once per frame
  void Update()
  {
    ManageState();
  }

  private void ManageState()
  {
    var nextStates = state.getNextStates();

    for (int i = 0; i < nextStates.Length; i++)
    {
        if(Input.GetKeyDown(KeyCode.Alpha1 + i))
        {
            state=nextStates[i];
        }
    }
    
    // if (Input.GetKeyDown(KeyCode.Alpha1))
    // {
    //   state = nextStates[0];
    // }
    // else if (Input.GetKeyDown(KeyCode.Alpha2))
    // {
    //   state = nextStates[1];
    // }
    // else if (Input.GetKeyDown(KeyCode.Alpha2))
    // {
    //   state = nextStates[2];
    // }

    textComponent.text = state.GetStateStory();
  }

}

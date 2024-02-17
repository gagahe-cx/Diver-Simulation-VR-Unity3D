using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Button endTurnButton;
 
    public void StartTimer() //Call this from OnClick
    {
        StartCoroutine(TimeoutEndTurnButton());
    }
    IEnumerator TimeoutEndTurnButton()
    {
        endTurnButton.interactable = false;
        yield return new WaitForSeconds(2f);
        endTurnButton.interactable = true;
    }
}

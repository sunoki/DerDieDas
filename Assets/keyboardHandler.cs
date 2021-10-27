using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class keyboardHandler : MonoBehaviour
{
    //Scripts
    private wordHandler scrWord;
    
    //UI
    public Button btnDer;
    public Button btnDie;
    public Button btnDas;

    void Start()
    {
        scrWord = this.GetComponent<wordHandler>();
        
    }

    // Update is called once per frame
    void Update()
    {
        var pointer = new PointerEventData(EventSystem.current);

        //Der button section
        if (Input.GetButtonDown("Der"))
        {
            //Using execute events, to not only call the onClick but also perform the animation on the button
            ExecuteEvents.Execute(btnDer.gameObject, pointer, ExecuteEvents.pointerDownHandler);
            ExecuteEvents.Execute(btnDer.gameObject, pointer, ExecuteEvents.submitHandler);
        }
        if (Input.GetButtonUp("Der"))
        {
            // to animate the release of the button as well
            ExecuteEvents.Execute(btnDer.gameObject, pointer, ExecuteEvents.pointerUpHandler);
        }


        //Die button section
        if (Input.GetButtonDown("Die"))
        {
            //Using execute events, to not only call the onClick but also perform the animation on the button
            ExecuteEvents.Execute(btnDie.gameObject, pointer, ExecuteEvents.pointerDownHandler);
            ExecuteEvents.Execute(btnDie.gameObject, pointer, ExecuteEvents.submitHandler);
        }
        if (Input.GetButtonUp("Die"))
        {
            // to animate the release of the button as well
            ExecuteEvents.Execute(btnDie.gameObject, pointer, ExecuteEvents.pointerUpHandler);
        }


        //Das button section
        if (Input.GetButtonDown("Das"))
        {
            //Using execute events, to not only call the onClick but also perform the animation on the button
            ExecuteEvents.Execute(btnDas.gameObject, pointer, ExecuteEvents.pointerDownHandler);
            ExecuteEvents.Execute(btnDas.gameObject, pointer, ExecuteEvents.submitHandler);
        }
        if (Input.GetButtonUp("Das"))
        {
            // to animate the release of the button as well
            ExecuteEvents.Execute(btnDas.gameObject, pointer, ExecuteEvents.pointerUpHandler);
        }
    }

}

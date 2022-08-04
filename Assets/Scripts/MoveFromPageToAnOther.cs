using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MoveFromPageToAnOther : MonoBehaviour
{
    public void playGame ()
    {
        int SelectedCharacter = 
        int.Parse(EventSystem.current.currentSelectedGameObject.name);

        //gamemanager.instance.CharIndex = SelectedCharacter ;
        SceneManager.LoadScene("Configuration");
    }
    private int sobhan_allah ;
    public void ReadInputSobhanAllahNumber (int n)
    {
        sobhan_allah = n ;
        Debug.Log (sobhan_allah) ;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void	PlayGame ()
    {
        SceneManager.LoadScene(1); //Voor als je met levels werkt, misschien werkt dit voor onze game ook, anders moet ik nog een aanpassing vinden
    }
}

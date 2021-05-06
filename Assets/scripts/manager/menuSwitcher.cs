using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuSwitcher : MonoBehaviour
{
    public GameObject start;
    public GameObject extra;
    public GameObject load;
    public GameObject save;
    public GameObject startGame;

    public void whichMenu(int page)
    {
        if (page == 0)  //start
        {
            startGame.SetActive(false);
            start.SetActive(true);
            extra.SetActive(false);
            load.SetActive(false);
            save.SetActive(false);
        }

        if (page == 1)  //start
        {
            start.SetActive(false);
            startGame.SetActive(true);
            extra.SetActive(false);
            load.SetActive(false);
            save.SetActive(false);
        }


        if (page == 2) //save
        {
            start.SetActive(false);
            startGame.SetActive(false);
            extra.SetActive(false);
            load.SetActive(false);
            save.SetActive(true);
        }

        if (page == 3) //load
        {

            start.SetActive(false);
            startGame.SetActive(false);
            extra.SetActive(false);
            load.SetActive(true);
            save.SetActive(false);
        }

        if (page == 5)  //extra
        {
            start.SetActive(false);
            startGame.SetActive(false);
            extra.SetActive(true);
            load.SetActive(false);
            save.SetActive(false);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public Menu[] menus;


    public void Open(Menu menu)
    {
        foreach (Menu m in menus)
        {
            if (m.isOpen)
            {
                m.Close();
            }
        }

        menu.Open();


    }

    public void Open(string name)
    {
        foreach(Menu m in menus)
        {
            if (m.name.Equals(name))
            {
                m.Open();
            }
            else
            {
                m.Close();
            }
        }
    }
}

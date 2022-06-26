using System;
using DI;
using UnityEngine;

namespace CruiseMod
{
    internal class TGG : MonoBehaviour
    {
        public void Start()
        {
            TGG.shouldDisplayMenu = false;
        }
        public void Update(KeyCode keyCode)
        {
            bool keyDown = 

        }

        public void ShowMenu()
        {
            TGG.shouldDisplayMenu = !TGG.shouldDisplayMenu;
        }


        private static bool shouldDisplayMenu;
    }
}

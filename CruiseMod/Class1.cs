using UnityEngine;
using ZML.API;

namespace MyCoolMod
{
    [ZMLMod("zml.antiparty.cruisemod", "Antiparty's Cruise tool", "1.0.0", "Antiparty")]
    public class MyCoolMod : BaseMod, IToolboxUI
    {

        public bool toggleCruise = false;
        public bool togl = false;
        public RaceCar[] allCars;

        public RaceCar playerCar;
        public static int savedrpm;
        string msg = "test rpm " + savedrpm.ToString();

        public void OnToolboxGUI()
        {
            
            if (GUILayout.Button("Cruise On")) {
                toggleCruise = true;
            } else {
                toggleCruise = false;
            }

            if (GUILayout.Toggle(toggleCruise, "35 Mph Lim")) {
                toggleCruise = true;
            } else {
                return;
            }
            GUILayout.Label("RPM test" + msg);

            // You can use any GUILayout calls here
        }
        public void OnToolboxOpen()
        {
            // Leave this function empty if you don't need it or initialize some stuff here if you want
            // You must however declare it because it is an interface
            CarSearch();
            rpmSet();
        }
        public void CarSearch()
        {
            this.allCars = Object.FindObjectsOfType<RaceCar>();
            for (int i = 0; i < this.allCars.Length; i++)
            {
                if (!this.allCars[i].isNetworkCar)
                {
                    this.playerCar = this.allCars[i];
                }
            }
        }
        public void rpmSet()
        {
            if (toggleCruise == true) {
                // Checking if Cruise mode is Active/on
                playerCar.carX.rpm = savedrpm;
                if (playerCar.carX.speedMPH > 35) {
                    playerCar.carX.rpm = 0;
                }
                else {
                    return;
                }
            }
        }
    }
}
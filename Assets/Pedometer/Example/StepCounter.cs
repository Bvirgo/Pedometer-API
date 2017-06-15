/* 
*   Pedometer
*   Copyright (c) 2017 Yusuf Olokoba
*/

namespace PedometerU.Tests {

    using UnityEngine;
    using UnityEngine.UI;

    public class StepCounter : MonoBehaviour {

        public Text stepText, distanceText;
        private Pedometer pedometer;

        private void Start () {
            // Create a new pedometer
            pedometer = new Pedometer(OnStep);
            // Reset UI
            OnStep(0, 0);
        }

        private void OnStep (int steps, double distance) {
            // Display the values
            stepText.text = steps.ToString();
            distanceText.text = distance.ToString("F2") + " ft";
        }

        private void OnDisable () {
            // Release the pedometer
            pedometer.Stop();
            pedometer = null;
        }
    }
}
using UnityEngine;

namespace SB.MyFarm.ProductionSystem {
    public class Tester : MonoBehaviour
    {
        #region Private Variables

        [SerializeField]
        private Road _road;
        [SerializeField]
        private Farm _farm;
        [SerializeField]
        private Machine _machine;

        #endregion

        #region Public Methods

        #region Unity Callbacks

        private void Update()
        {
            if (Input.GetKey(KeyCode.R))
            {
                if (Input.GetKeyDown(KeyCode.D))
                    _road.Remove();
                else if (Input.GetKeyDown(KeyCode.U))
                    _road.Upgrade();
            }else if (Input.GetKey(KeyCode.F))
            {
                if (Input.GetKeyDown(KeyCode.D))
                    _farm.Remove();
                else if (Input.GetKeyDown(KeyCode.T))
                    _farm.Rotate();
            }
            else if (Input.GetKey(KeyCode.M))
            {
                if (Input.GetKeyDown(KeyCode.C))
                    _machine.Craft();
                else if (Input.GetKeyDown(KeyCode.T))
                    _machine.Rotate();
                else if (Input.GetKeyDown(KeyCode.D))
                    _machine.Remove();
            }
        }

        #endregion

        #endregion
    }
}

using System;
using UnityEngine;

namespace SB.MyFarm.ProductionSystem
{
    public abstract class RotatableBuilding : Building, IRotate
    {
        #region Public Variables

        public event Action OnRotate;

        #endregion

        #region Public Methods

        public void Rotate()
        {
            transform.Rotate(Vector3.up, 90);

            OnRotate?.Invoke();

            Debug.Log("Rotate");
        }

        #endregion
    }
}

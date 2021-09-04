using System;
using UnityEngine;

namespace SB.MyFarm.ProductionSystem
{
    public class Machine : RotatableBuilding, ICraft
    {
        #region Public Variables

        public event Action OnCraft;

        #endregion

        #region Public Methods

        public void Craft()
        {
            OnCraft?.Invoke();

            Debug.Log("Craft");
        }

        #endregion
    }
}

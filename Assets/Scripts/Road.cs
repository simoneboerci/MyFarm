using System;
using UnityEngine;

namespace SB.MyFarm.ProductionSystem
{
    public class Road : Building, IUpgradable
    {
        #region Public Variables

        public event Action OnUpgrade;

        #endregion

        #region Public Methods

        public void Upgrade()
        {
            OnUpgrade?.Invoke();

            Debug.Log("Upgrade");
        }

        #endregion
    }
}

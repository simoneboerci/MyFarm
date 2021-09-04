using System;
using UnityEngine;

namespace SB.MyFarm.ProductionSystem
{
    public abstract class Building : MonoBehaviour, IRemovable
    {
        #region Public Variables

        public event Action OnRemove;

        #endregion

        #region Public Methods

        public void Remove()
        {
            OnRemove?.Invoke();

            OnRemove = null;

            Destroy(gameObject);
        }

        #endregion
    }
}

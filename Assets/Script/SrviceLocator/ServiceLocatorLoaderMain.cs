using NUnit.Framework.Internal;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.ReorderableList.Internal;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

namespace Examples.VerticalScrollerExample
{
    /// <summary>
    /// Загрузчик сервисов для сцены с игрой
    /// </summary>
    public class ServiceLocatorLoader_Main : MonoBehaviour
    {
        [SerializeField] private SphereCharacter _character;

        [SerializeField] private Enemy _enemy;

        private void Awake()
        {
            ServiceLocator.Initialize();

            ServiceLocator.Current.Register(_character);

            ServiceLocator.Current.Register(_enemy);
        }
    }
}
using Agate.MVC.Base;
using ExampleGame.GameSystem.Module.ClickGame;
using UnityEngine;

namespace ExampleGame.GameSystem
{
    public class GameSystemView : BaseSceneView
    {
        [SerializeField]
        public ClickGameView ClickGameView;
    }

}
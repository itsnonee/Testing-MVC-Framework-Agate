using System;
using UnityEngine;
using Agate.MVC.Base;
using UnityEngine.UI;
using UnityEngine.Events;

namespace ExampleGame.Home
{
    public class HomeView : BaseSceneView
    {
        [SerializeField]
        private Button _gamePlayButton;
        [SerializeField]
        private Button _gameSystemButton;
        
        public void SetCallbacks(UnityAction onClickGamePlayButton, UnityAction onClickGameSystemButton)
        {
            _gamePlayButton.onClick.RemoveAllListeners();
            _gameSystemButton.onClick.RemoveAllListeners();
            _gamePlayButton.onClick.AddListener(onClickGamePlayButton);
            _gameSystemButton.onClick.AddListener(onClickGameSystemButton);

        }
    }
}
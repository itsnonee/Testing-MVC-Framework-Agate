using Agate.MVC.Base;
using UnityEngine;

namespace ExampleGame.Module.Soundfx
{
    public class SoundfxController : BaseController<SoundfxController>
    {
        public void OnUpdateCoin()
        {
            Debug.Log("Play Sound fx");
        }
    }
}
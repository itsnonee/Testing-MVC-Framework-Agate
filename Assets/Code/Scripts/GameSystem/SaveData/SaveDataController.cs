using System.Collections;
using Agate.MVC.Base;

namespace ExampleGame.GameSystem.Module.SaveData
{
    public class SaveDataController : DataController<SaveDataController, SaveDataModel, ISaveDataModel>
    {
        private void SaveData()
        {
        }

        private void LoadData()
        {
        }

        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            LoadData();
        }

        public void OnUpdateCoin(int coin)
        {
            
        }
    }
}
using IJunior.TypedScenes;
using UnityEngine;

namespace CityFac.Scripts
{
    public class SampleSceneEntry : MonoBehaviour, ISceneLoadHandler<string>
    {
        public void OnSceneLoaded(string argument)
        {
            Debug.Log(argument);
        }
    }
}

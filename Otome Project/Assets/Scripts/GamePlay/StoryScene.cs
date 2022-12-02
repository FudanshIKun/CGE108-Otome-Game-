using System.Collections.Generic;
using UnityEngine;

namespace Otome.GamePlay
{
    [CreateAssetMenu(fileName = "NewStoryScene", menuName = "Data/New Story Scene")]
    [System.Serializable]
    public class StoryScene : ScriptableObject
    {
        public List<Sentence> Sentences;
        public StoryScene nextScene;

        [System.Serializable]
        public struct Sentence
        {
            public string text;
            public Character Character;

            public enum EmotionList
            {
                normal,
                smile,
                Angry
            }
            public EmotionList SpriteEmotion;
            public Texture2D Place;
            public AudioClip Soundfx;

        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Vocabulary
{
    public static class Words
    {
        public static string GetWord(EWord word, SystemLanguage lang)
        {
            switch (lang)
            {
                case SystemLanguage.English:
                    switch (word)
                    {
                        case EWord.music: return "Music";
                        case EWord.sfx: return "Sfx";

                        default:
                            throw new NotImplementedException("Word don't exist!");
                    }

                case SystemLanguage.Russian:
                    switch (word)
                    {
                        case EWord.music: return "Музыка";
                        case EWord.sfx: return "Звуки";

                        default:
                            throw new NotImplementedException("Word don't exist!");
                    }


                default:
                    throw new NotImplementedException("Language don't supported!");
            }
        }

        public static SystemLanguage[] SupportedLanguages
        {
            get
            {
                SystemLanguage[] arr = new SystemLanguage[2];
                arr[0] = SystemLanguage.English;
                arr[1] = SystemLanguage.Russian;


                return arr;
            }
        }
    }


    public enum EWord
    {
        music, sfx,
    }
}
